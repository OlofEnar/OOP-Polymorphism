
namespace Labb7_OOP_Polymorphism
{
    internal class Circle : Geometry
    {
        //Constructor
        public Circle()
        {
            Radius = 4;
        }

        //Override base method with the shape's area calculation
        public override double CalcArea()
        {
            return Radius * Radius * Pi;
        }
    }
}
