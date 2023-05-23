# `Mtconnect.AdapterInterface`
An assembly for implementing custom software Adapters capable of connecting with the reference [MTConnect&reg; Agent](https://github.com/mtconnect/cppagent).

The `Adapter` is a generic container for a set of `DataItem`s, state management, and string formatting (relative to the reference MTConnect&reg; Agent). See the `[TcpAdapter](../MtconnectCore.TcpAdapter)` for an example of how to implement this interface.

# Adapter Configuration
There are a few generic configuration options that can be made:

 - `heartbeat`
 - `enqueue`
 - `dataItem:{internalName}:name`: Overwrites the output name for the data item.
 - `dataItem:{internalName}:format`: Allows the output value for a data item to be overwritten or formatted based on C# script.

## Data Item Format Script
The `format` script MUST be written in C# and return a `Func<object, object>`. For example:

```c#
return o => System.DateTime.Now.ToString();
```

The raw C# script MUST be encrypted using a Certificate which should be installed on the target device by an administrator. Raw scripts, like the example above, can be encrypted by using the `Mtconnect.AdapterInterface.Scripting.EncryptScript` method. This method requires the location of the Certificate to be used for encryption and the raw script itself. For example:

``` c#
string rawScript = @"return o => System.DateTime.Now.ToString();";
string certLocation = @"{Enter Certificate filepath}";

string encryptedScript = Mtconnect.AdapterInterface.Scripting.EncryptScript(certLocation, rawScript);
```

The encrypted script string can then be used in the App.config file. For example:

``` xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
		<section name="adapter" type="System.Configuration.DictionarySectionHandler" />
	</configSections>
	<adapter>
		<add key="dataItem:xPos:format" value="{encrypted script string}" />
	</adapter>
</configuration>
```

### Creating a Self-Signed Certificate
This is a rough example on creating a self-signed certificate in Windows using OpenSSL.

 - Install OpenSSL on your development computer.
 - Add OpenSSL `bin` folder to your Environment Variables
  - Search 'Advanced System Settings'
  - Click 'Environment Variables...'
  - Select 'Path' or add a new user variable and name it 'Path'
  - Edit 'Path'
  - Add a New item to the list with the location of the OpenSSL bin folder
 - Open either a Command Prompt or Powershell as an Administrator
 - Edit and run the following command to create the public key and certificates:

``` Powershell
>$certName = "{enter name for certification}"
>openssl req -x509 -newkey rsa:2048 -keyout $certName + "-key.pem" -out $certName + "-cert.pem"
```

Enter a private pass phrase for your certificate followed by your organizations information.

Once the key and certificate files have been created, run the following command to create a combined certificate.

``` Powershell
openssl pkcs12 -export -in $certName + "-cert.pem" -inkey certName + "-key.pem" -out $certName + ".pfx"
```

When prompted for an "Export Password", simply press enter to skip.

Once the combined certificate has been created, you can create a public certificate:

``` Powershell
openssl pkcs12 -in $certName + ".pfx" -clcerts -nokeys -out $certName + "-public-cert.pem"
```

When the `.pfx` has been created, you can reference this file when executing the `Mtconnect.AdapterInterface.Scripting.EncryptScript` method.