using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Debugger
{
    public class ValueDebugger
    {
        virtual internal void Debugger(string stringer, int inter, double doubler)
        {
            Debug.WriteLine("String" + stringer);
            Debug.Write("Int" + inter);
            Debug.Write("Double" + doubler);
        }
    }
}
