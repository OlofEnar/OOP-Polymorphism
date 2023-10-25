
namespace Labb7_OOP_Polymorphism
{
    //Base class
    internal abstract class Geometry
    {
        public double Pi = 3.14;
        public double Radius { get; set; }
        public int Height { get; set; }
        public int Base { get; set; }

        //Method to be overwritten by derived classes
        public virtual double CalcArea()
        {
            return 0;
        }
    }
}