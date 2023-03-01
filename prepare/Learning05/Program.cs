using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square s = new Square("red", 8);
        shapes.Add(s);

        Rectangle r = new Rectangle("blue", 3,5);
        shapes.Add(r);

        Circle c = new Circle("green", 1);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}