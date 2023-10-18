using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testzkusebni
{
    internal class Person
    {
        public string Name { get; set; }
        public int Vek { get; internal set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
