$certname = "MtconnectAdapter";
$dllLocation = "..\AdapterInterface.dll";

Function Write-SSL($certName) {
	$country = "US";
	$state = "IN";
	$locality = "Plainfield";
	$organizationalUnit = "MTConnect";
	$organization = "True Analytics Manufacturing Solutions, LLC";
	$commonName = "mtconnect.org";
	$emailAddress = "support@tams.ai";
	$subject = "/C=" + $country + "/ST=" + $state + "/L=" + $locality + "/O=" + $organization + "/OU=" + $organizationalUnit + "/CN=" + $commonName + "/emailAddress=" + $emailAddress;

	If (-NOT ([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
	{
		Write-Host "This script needs to be Run As Admin" -ForegroundColor Red;
		Return $false;
	}

	$thisFolder = [string](Get-Location) + "\";
	$configFile = ($thisFolder + "ssl.cnf");
	$certFileName = ($certName + ".crt");
	$keyFileName = ($certName + ".key");
	$publicCertFileName = ($certName + "-public.crt");

	Write-Host "Key File: " $keyFileName -ForegroundColor Yellow;
	Write-Host "Cert File: " $certFileName -ForegroundColor Yellow;

	#openssl req -x509 -days 365 -nodes -newkey rsa:2048 -keyout ($thisFolder + $keyFileName) -out ($thisFolder + $certFileName) -conifg $configFile;
	openssl req -x509 -days 365 -nodes -newkey rsa:2048 -keyout $keyFileName -out $certFileName -subj $subject;
	# Start-Process "C:\Program Files\OpenSSL\bin\openssl.exe" -Argumentlist "req -x509 -days 365 -nodes -newkey rsa:2048 -keyout $keyFileName -out $certFileName -subj $subject"

	openssl pkcs12 -export -in ($thisFolder + $certFileName) -inkey ($thisFolder + $keyFileName) -out ($thisFolder + $certName + ".pfx");

	openssl pkcs12 -in ($thisFolder + $certName + ".pfx") -clcerts -nokeys -out ($thisFolder + $publicCertFileName);

	return $true;
}

If (-NOT (Test-Path -Path "$certName.crt" -PathType Leaf)) {
	If (-NOT (Write-SSL($certName))) {
		Write-Host "Failed to write SSL Certificate" -ForegroundColor Red;
		Break;
	}
}

If (-NOT (Test-Path -Path ($thisFolder + $dllLocation) -PathType Leaf)) {
	Write-Host "Missing AdapterInterface.dll in parent directory" -ForegroundColor Red;
	Break;
}
$dll = Resolve-Path ($thisFolder + $dllLocation);

$cert = Resolve-Path "$certName.crt";


[Reflection.Assembly]::LoadFile($dll);

$configContents = "<!-- Generated from Sandbox script -->";
Get-ChildItem -Path ".\" -Filter "*.cs" | Foreach-Object {
	$dataItemName = $_.Basename;
	Write-Host "Reading script file for data item '$dataItemName'";
	
	$script = Get-Content $_.FullName;
	
	$encryptedScript = [Mtconnect.AdapterInterface.Cryptography.ConfigurationEncrypter]::Encrypt($cert, $script);
	
	$configContents = $configContents + "`r`n<add key=`"dataItem:" + $dataItemName + ":format`" value=`"" + $encryptedScript + "`" />";
}

$configContents | Out-File -FilePath "appSettings.config" -Force

Write-Host "Finished writing data item format options to appSettings.config" -ForegroundColor Green;
Write-Host "Press enter to finish" -ForegroundColor Gray;
Read-Host