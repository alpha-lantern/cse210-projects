class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square sqr1 = new Square("blue", 8);
        Rectangle rect1 = new Rectangle("yellow", 4.5, 17.3);
        Circle circle1 = new Circle("red", 1.8);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(sqr1);
        shapes.Add(rect1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine($"Area: {shape.GetArea():F2}");
        }
    }
}