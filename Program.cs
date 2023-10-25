
namespace Labb7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make a list with objects derived from base class Geometry
            List<Geometry> shapes = new List<Geometry>()
            {   new Circle(),
                new Ellipse(),
                new Square(),
                new Rectangle(),
                new Parallelogram()
            };

            //Loop through all objects
            //Get class name and run each unique calculation
            foreach (var item in shapes)
            {
                Console.WriteLine($"{item.GetType().Name} " +
                    $"has area: {item.CalcArea()}"); 
            }
        }
    }
}