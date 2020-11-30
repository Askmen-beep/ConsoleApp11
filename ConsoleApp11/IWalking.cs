using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp11
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public  class IWalking
    {
        public void Walk1()

        {

            Console.WriteLine(this + " идет в новую точку");

        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
