using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Butterfly
    {
        public string Name

        { get; set; }
        public DateTime Birthday { get; }

        public override string ToString() => Name;

        public Butterfly(string name, DateTime birthday)

        {

            Name = name;

            Birthday = birthday;
        }
    }
}
