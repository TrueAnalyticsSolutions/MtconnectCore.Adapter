# What is the Sandbox?
The sandbox allows you to generate self-signed certificates locally and test scripts for Data Item configurations.

# How to setup the sandbox
Simply add `.cs` files for each Data Item you want to format. For example, if you have a `EXECUTION`, `PATH_POSITION`, and `MODE` Data Items:

```
.\exec.cs
.\xPos.cs
.\yPos.cs
.\mode.cs
```

Notice the filenames match the internal Data Item names for the Adapter.

## Code format
The format for the C# within each script file should always return a `Func<object, object>`. The simplest example:

```c#
return o => o;
```

However, your scripts can be more complex if necessary:

```c#
return o => {
	System.Console.WriteLine("This is an example of additional processing.");

	return System.DateTime.UtcNow;
}
```

## Security
Obviously, allowing scripting in the configuration can present an opportunity for malicious code to be injected into the adapter. So, the adapter expects all formatting scripts defined in the config to be encrypted. The `Sandbox.ps1` PowerShell script helps handle the creation of Self-Signed Certificates in your development environment and uses those certificates to encrypt the C# files within the Sandbox. The result of using the script will create a `appSettings.config` file which you can then use to copy the contents into the `App.config` for your Adapter.

Note that the target computer for your Adapter must also have a registration of the Certificate used to encrypt the formatting scripts so the scripts can then be decrypted on the target computer.