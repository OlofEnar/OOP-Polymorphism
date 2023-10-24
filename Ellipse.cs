using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_OOP_Polymorphism
{
    internal class Ellipse : Geometry
    {
        public int MajorRadius;
        public int MinorRadius;

        public Ellipse()
        {
            MajorRadius = 5;
            MinorRadius = 3;
        }

        public override double CalcArea()
        {
            return MajorRadius * MinorRadius * Math.PI;
        }
    }
}
