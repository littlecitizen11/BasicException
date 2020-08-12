using System;
using System.IO;
using Logic;
using Microsoft.Extensions.Logging;

namespace BasicException
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLogics rl = new RunLogics();
            rl.RunLogic1();
        }
    }
}
