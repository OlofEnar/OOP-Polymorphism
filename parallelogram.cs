
namespace Labb7_OOP_Polymorphism
{
    internal class Parallelogram : Geometry
    {
        //Constructor
        public Parallelogram()
        {
            Base = 3;
            Height = 5;
        }

        //Override base method with the shape's area calculation
        public override double CalcArea()
        {
            return Base * Height;
        }
    }
}
