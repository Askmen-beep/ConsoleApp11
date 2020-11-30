using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    
        public interface IFlying

        {

            public void Fly()

            {

                Console.WriteLine(this + " летит в новую точку");

            }
        }
    
}
