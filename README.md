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
