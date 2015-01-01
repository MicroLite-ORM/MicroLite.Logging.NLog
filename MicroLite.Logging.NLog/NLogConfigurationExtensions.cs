// -----------------------------------------------------------------------
// <copyright file="NLogConfigurationExtensions.cs" company="MicroLite">
// Copyright 2012 - 2014 Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
namespace MicroLite.Configuration
{
    using System;
    using MicroLite.Logging.NLog;

    /// <summary>
    /// Extensions for the MicroLite configuration.
    /// </summary>
    public static class NLogConfigurationExtensions
    {
        /// <summary>
        /// Configures the MicroLite ORM Framework to use NLog as the logging framework.
        /// </summary>
        /// <param name="configureExtensions">The interface to configure extensions.</param>
        /// <returns>The configure extensions.</returns>
        public static IConfigureExtensions WithNLog(this IConfigureExtensions configureExtensions)
        {
            if (configureExtensions == null)
            {
                throw new ArgumentNullException("configureExtensions");
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: loading NLog extension.");

            configureExtensions.SetLogResolver((Type type) =>
            {
                var logger = global::NLog.LogManager.GetLogger(type.FullName);

                return new LogAdapter(logger);
            });

            System.Diagnostics.Trace.TraceInformation("MicroLite: NLog extension loaded.");

            return configureExtensions;
        }
    }
}