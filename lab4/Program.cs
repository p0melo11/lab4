using System;
using System.Diagnostics;

namespace Debugger
{
    class Program
    {
        static void Main()
        {
            var typeDebugger = new TypeDebugger();

            typeDebugger.Debugger("lab4", 10, 10.10);
        }
    }
}
