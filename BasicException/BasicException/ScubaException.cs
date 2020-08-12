using System;
using System.Collections.Generic;
using System.Text;

namespace BasicException
{
    public class ScubaException : Exception
    {
        public int StudentNum { get; }
        public ScubaException(string message) : base(message) { StudentNum = int.Parse(Console.ReadLine()); Console.WriteLine($"Hey {StudentNum}, You have an exception as ScubaException"); }
    }
}
