
namespace Labb7_OOP_Polymorphism
{
    internal class Rectangle : Geometry
    {
        //Constructor
        public Rectangle()
        {
            Height = 3;
            Base = 6;
        }

        //Override base method with the shape's area calculation
        public override double CalcArea()
        {
            return Base * Height;
        }
    }
}
