using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Rectangle : Geometry
    {

        public Rectangle()
        {
            Height = 3;
            Base = 6;
        }

        public override double CalcArea()
        {
            return Base * Height;
        }
    }
}
