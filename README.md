# MicroLite.Logging.NLog

MicroLite.Logging.NLog is a .NET 4.5 library which adds an extension for the MicroLite ORM Framework to use NLog as the logging library.

![Nuget](https://img.shields.io/nuget/dt/MicroLite.Logging.NLog)

|Branch|Status|
|------|------|
|/develop|![GitHub last commit (branch)](https://img.shields.io/github/last-commit/MicroLite-ORM/MicroLite.Logging.NLog/develop) [![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.NLog?branchName=develop)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=33&branchName=develop) ![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/MicroLite.Logging.NLog)|
|/master|![GitHub last commit](https://img.shields.io/github/last-commit/MicroLite-ORM/MicroLite.Logging.NLog/master) [![Build Status](https://dev.azure.com/trevorpilley/MicroLite-ORM/_apis/build/status/MicroLite-ORM.MicroLite.Logging.NLog?branchName=master)](https://dev.azure.com/trevorpilley/MicroLite-ORM/_build/latest?definitionId=33&branchName=master) ![Nuget](https://img.shields.io/nuget/v/MicroLite.Logging.NLog) ![GitHub Release Date](https://img.shields.io/github/release-date/MicroLite-ORM/MicroLite.Logging.NLog)|

## Installation

Install the nuget package `Install-Package MicroLite.Extensions.NLog`

## Configuration

You can then load the extension in your application start-up:

    // Load the extensions for MicroLite
    Configure
       .Extensions()
       .WithNLog();

    // Create the session factory...
    Configure
       .Fluently()
       ...

For further information on configuring NLog, see [github.com/nlog/nlog/wiki/Tutorial](https://github.com/nlog/nlog/wiki/Tutorial).

## Supported .NET Versions

The NuGet Package contains binaries compiled against (dependencies indented):

* .NET Framework 4.5
  * MicroLite 7.0.0
  * NLog 4.4.0
