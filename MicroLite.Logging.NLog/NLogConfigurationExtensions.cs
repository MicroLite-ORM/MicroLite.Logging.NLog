﻿// -----------------------------------------------------------------------
// <copyright file="NLogConfigurationExtensions.cs" company="Project Contributors">
// Copyright Project Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// </copyright>
// -----------------------------------------------------------------------
using System;
using MicroLite.Logging.NLog;

namespace MicroLite.Configuration
{
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
            if (configureExtensions is null)
            {
                throw new ArgumentNullException(nameof(configureExtensions));
            }

            System.Diagnostics.Trace.TraceInformation("MicroLite: loading NLog extension.");

            configureExtensions.SetLogResolver((Type type) =>
            {
                NLog.Logger logger = NLog.LogManager.GetLogger(type.FullName);

                return new LogAdapter(logger);
            });

            System.Diagnostics.Trace.TraceInformation("MicroLite: NLog extension loaded.");

            return configureExtensions;
        }
    }
}
