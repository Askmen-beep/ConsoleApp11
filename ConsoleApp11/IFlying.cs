using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    
        public interface IFlying

        {//3

            public void Fly()

            {

                Console.WriteLine(this + " летит в новую точку");

            }
        }
    
}
