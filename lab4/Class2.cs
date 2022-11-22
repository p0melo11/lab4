using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Debugger
{
    public class TypeDebugger : ValueDebugger
    {
        internal override void Debugger(string stringer, int inter, double doubler)
        {
            var prevColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("String" + stringer.GetType());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Int" + inter.GetType());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Double" + doubler.GetType());

            Console.ForegroundColor = prevColor;
        }
    }
}
