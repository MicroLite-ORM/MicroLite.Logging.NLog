MicroLite.Logging.NLog
======================

[![NuGet version](https://badge.fury.io/nu/MicroLite.Logging.NLog.svg)](http://badge.fury.io/nu/MicroLite.Logging.NLog)

_MicroLite.Logging.NLog_ is an extension to the MicroLite ORM Framework which allows MicroLite to write any log statements to [NLog](http://nlog-project.org/).

In order to use the extension, you first need to install it via NuGet:

    Install-Package MicroLite.Logging.NLog

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

## Supported .NET Framework Versions

The NuGet Package contains binaries compiled against:

* .NET 3.5 (Full)
* .NET 4.0 (Full)
* .NET 4.5

## Supported NLog Versions

* NLog 3.0.0 onwards
