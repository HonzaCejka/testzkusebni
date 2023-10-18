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
        public string YearDef { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public void starnout()
        {
            Vek++;
            switch (Vek)
            {                
                case 1:
                    YearDef = " Rok";
                    break;
                case 2:
                    YearDef = " Roky";
                    break;
                case 3:
                    YearDef = " Roky";
                    break;
                case 4:
                    YearDef = " Roky";
                    break;
                default:
                    break;
            }
            if (Vek >= 5)
            {
                YearDef = " Let";
            }            
        }
    }
}
