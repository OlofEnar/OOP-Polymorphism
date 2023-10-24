using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Geometry
    {
        public double Radius { get; set; }
        public int Height { get; set; }
        public int Base { get; set; }


        public virtual double CalcArea()
        {
            return 0;
        }
    }
}
