using System;
using System.Collections.Generic;
using System.Text;

namespace BasicException
{
    public class ScubaException : Exception
    {
        public int StudentNum { get; }
        public ScubaException(string message, int studentnum) : base(message) { }
    }
}
