﻿using System;
using System.Runtime.Serialization;

namespace VCSVersion.VersionCalculation.BaseVersionCalculation
{
    [Serializable]
    public class BaseVerisonException : Exception
    {
        public BaseVerisonException() { }
        public BaseVerisonException(string message) : base(message) { }
        public BaseVerisonException(string message, Exception inner) : base(message, inner) { }

        protected BaseVerisonException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        { }
    }
}