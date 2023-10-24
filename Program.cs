namespace Labb7_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry ellipse = new Ellipse();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();
            Geometry parallelogram = new Parallelogram();


            Console.WriteLine($"{circle.CalcArea()};");
        }
    }
}