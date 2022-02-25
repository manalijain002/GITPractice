using System;
using System.Collections.Generic;
using System.Text;

namespace Csh8Features
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Name  " + Name + " Basic  " + Basic;
        }
    }
}
