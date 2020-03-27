// -----------------------------------------------------------------------
// <copyright file="LogAdapter.cs" company="Project Contributors">
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
using System.Globalization;

namespace MicroLite.Logging.NLog
{
    internal sealed class LogAdapter : ILog
    {
        private readonly global::NLog.Logger _log;

        internal LogAdapter(global::NLog.Logger log) => _log = log;

        public bool IsDebug => _log.IsDebugEnabled;

        public bool IsError => _log.IsErrorEnabled;

        public bool IsFatal => _log.IsFatalEnabled;

        public bool IsInfo => _log.IsInfoEnabled;

        public bool IsWarn => _log.IsWarnEnabled;

        public void Debug(string message) => _log.Debug(message);

        public void Debug(string message, params string[] formatArgs) => _log.Debug(CultureInfo.InvariantCulture, message, (object[])formatArgs);

        public void Error(string message) => _log.Error(message);

        public void Error(string message, params string[] formatArgs) => _log.Error(CultureInfo.InvariantCulture, message, (object[])formatArgs);

        public void Error(string message, Exception exception) => _log.Error(exception, message, null);

        public void Fatal(string message) => _log.Fatal(message);

        public void Fatal(string message, params string[] formatArgs) => _log.Fatal(CultureInfo.InvariantCulture, message, (object[])formatArgs);

        public void Fatal(string message, Exception exception) => _log.Fatal(exception, message, null);

        public void Info(string message) => _log.Info(message);

        public void Info(string message, params string[] formatArgs) => _log.Info(CultureInfo.InvariantCulture, message, (object[])formatArgs);

        public void Warn(string message) => _log.Warn(message);

        public void Warn(string message, params string[] formatArgs) => _log.Warn(CultureInfo.InvariantCulture, message, (object[])formatArgs);
    }
}
