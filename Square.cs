using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Square : Geometry
    {
        public Square()
        {
            Base = 4;
        }

        public override double CalcArea()
        {
            return Base * 2;
        }
    }
}
