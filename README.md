[![Publish to Package Registries](https://github.com/TrueAnalyticsSolutions/Mtconnect.Adapter/actions/workflows/main.yml/badge.svg?branch=tbm0115%2FConfigOptionEncryption)](https://github.com/TrueAnalyticsSolutions/Mtconnect.Adapter/actions/workflows/main.yml)

Based on the [Dot Net SDK](https://github.com/mtconnect/dot_net_sdk)


MTConnect&reg; Adapter by TAMS
==========

This repo contains two important libraries for implementing a MTConnect&reg; Adapter each providing tools for rapid Adapter development.

## `AdapterInterface`
An assembly for implementing custom software adapters formatted for connecting with the reference [MTConnect&reg; Agent](https://github.com/mtconnect/cppagent).

See the [AdapterInterface](/AdapterInterface/Readme.md) project readme for more information.

## `TcpAdapter`
An implementation of the abstract `Adapter` class within the `AdapterInterface` that communicates with the reference [MTConnect&reg; Agent](https://github.com/mtconnect/cppagent) via TCP/IP.

See the [MtconnectCore.TcpAdapter](/MtconnectCore.TcpAdapter/Readme.md) project readme for more information.


## Examples
See the [Wiki](https://github.com/TrueAnalyticsSolutions/Mtconnect.Adapter/wiki) for examples on implementing an Adapter.

## Features
Here is a list of important features that this library provides:

### Configuration Options
This Adapter library provides some configuration options to alter the behavior of the Adapter and output of DataItems. Some of those options include:
 - `enqueue` indicates whether or not the Adapter should queue all incoming data. Allowing the Adapter to queue DataItems can ensure that all values are sent to a client. Traditionally, Adapters only send the most current DataItem value, allowing some changes to the DataItems to be lost due to the sample rate.
 - `heartbeat` allows you to manipulate the heartbeat of the Adapter.

#### DataItem Options
Individual DataItem configuration is also available, giving you more control over how each DataItem is processed before sending to the client(s).
 - `name` allows you to override the DataItem name that is sent to the client(s).
 - `format` allows you to override the value that is sent to the client(s). NOTE: This option MUST be encrypted for security purposes.
 
#### TCP Options
When communicating with clients via TCP, here are some options for setting up those connections:
 - `address` allows you to explicitly specify the IP Address you wish to host the Adapter on.
 - `port` allows you to explicitly specify the port number you wish to host the Adapter on.
 - `maxConnections` allows you to adjust how many concurrent client connections you wish the Adapter to handle at any given point.
 
#### UPnP Options
Adapters can optionally make themselves discoverable using UPnP by adding the `UPnP` property to the Adapter configuration section of the appsettings. Here are some of the settings for configuring the UPnP host:
 - `Type` specifies the `System.Type` of the `UPnPService` implementation.
 - `Options` is a dictionary of constructor parameters for the `UPnPService` implementations:
   - `broadcastRate` is the rate (in milliseconds) at which the service will publish a (`ssdp:update`) notification on the network. The default is essentially 24hrs.
   - `address` is the intended IP Address to host the HTTP server. The default is `localhost`
   - `port` is the intended port number to host the HTTP servre. The default is `7879`. This value must be unique on the machine
 
### API
In order to stay compliant with the reference MTConnect C++ Agent, there are some commands that must be issued to the Agent. This Adapter library expands on this concept by allowing the TCP clients to issue commands to retrieve this information on-demand.

#### Agent Commands
These are commands that can be issued to the client(s) (aka Agent):
 - `* PONG <heartbeat>`
 - `* adapterVersion: <version>`
 - `* calibration: XXX`
 - `* conversionRequired: <yes|no>`
 - `* device: <uuid|name>`
 - `* description: XXX`
 - `* manufacturer: XXX`
 - `* mtconnectVersion: <version>`
 - `* nativeName: XXX`
 - `* realTime: <yes|no>`
 - `* relativeTime: <yes|no>`
 - `* serialNumber: XXX`
 - `* shdrVersion: <version>`
 - `* station: XXX`
 
#### Adapter Commands
These are commands that can be issued to the Adapter from the client(s):
 - `* PING` returns the `PONG` Agent command
 - `* dataItems` returns a pipe-delimitted list of the registered DataItem names.
 
 Example:
 ```
 <* dataItems: avail|exec|xPos
 ```
 - `* dataItemDescription: <name>` returns the description, if available, for the provided DataItem.
 
 Example:
 ```
 >* dataItemDescription: exec
 <* dataItemDescription: The execution state of NC code on the main controller
 ```
 - `* dataItem: <name>` returns the current value of the provided DataItem.
 
 Example:
 ```
 >* dataItem: exec
 <* dataItem: READY
 ```
