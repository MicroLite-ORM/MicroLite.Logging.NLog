MicroLite.Logging.NLog
======================

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

_Supported .NET Framework Versions_

The NuGet Package contains binaries compiled against 3.5, 4.0 and 4.5.