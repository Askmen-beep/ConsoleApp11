using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Bird
    {
        public string Name

        { get; set; }
        public DateTime Birthday { get; private set; }

        public override string ToString() => Name;

        public Bird(string name, DateTime birthday)

        {

            Name = name;

            Birthday = birthday;
        }
    }
}

