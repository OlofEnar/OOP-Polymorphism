
namespace Labb7_OOP_Polymorphism
{
    internal class Square : Geometry
    {
        //Constructor
        public Square()
        {
            Base = 4;
        }

        //Override base method with the shape's area calculation
        public override double CalcArea()
        {
            return Base * 2;
        }
    }
}
