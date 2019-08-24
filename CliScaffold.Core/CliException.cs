﻿using System;

namespace CliScaffold.Core
{
    public sealed class CliException : Exception
    {
        public CliException(string msg)
            : base(msg)
        {
        }

        public CliException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
    }
}
