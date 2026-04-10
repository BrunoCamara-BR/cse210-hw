using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 3);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("yellow", 2, 3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("purple", 2);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine("--------------------");
        shapes.ForEach(item =>
        {
            Console.WriteLine(item.GetColor());
            Console.WriteLine(item.GetArea());
        });
    }
}