using System;
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Rectangle sp1 = new Rectangle("black", 3, 6);
        shapes.Add(sp1);

        Circle sp2 = new Circle("Red", 5);
        shapes.Add(sp2);

        Square sp3 = new Square("green", 4);
        shapes.Add(sp3);

        foreach (Shape sp in shapes)
        {
            string color = sp.GetColor();

            double area = sp.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}