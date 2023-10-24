using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Parallelogram : Geometry
    {
        public Parallelogram()
        {

        }

        public override double CalcArea()
        {
            return Base * Height;
        }
    }
}
