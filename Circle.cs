using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Circle : Geometry
    {

        public Circle()
        {
            Radius = 5;
        }

        public override double CalcArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
