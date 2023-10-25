
namespace Labb7_OOP_Polymorphism
{
    internal class Ellipse : Geometry
    {
        public int MajorRadius;
        public int MinorRadius;

        //Constructor
        public Ellipse()
        {
            MajorRadius = 5;
            MinorRadius = 3;
        }

        //Override base method with the shape's area calculation
        public override double CalcArea()
        {
            return MajorRadius * MinorRadius * Pi;
        }
    }
}
