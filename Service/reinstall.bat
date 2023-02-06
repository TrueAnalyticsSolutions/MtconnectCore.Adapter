@ECHO OFF

echo Uninstalling MTConnect Adapter Windows Service...
sc delete MTConnectAdapter

echo Installing MTConnect Adapter Windows Service...
sc create MTConnectAdapter displayName="MTConnect Adapter" BinPath="%~dp0Service.exe" Start=Auto
sc description MTConnectAdapter "A MTConnect Adapter to be consumed by a MTConnect Agent"
echo Done. Press enter to exit.
pause
