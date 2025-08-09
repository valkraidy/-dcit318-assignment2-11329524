using Abstract_Classes_and_Methods;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Abstract Classes and Methods");
        Shape circle = new Circle(4);       // Radius = 4
        Shape rectangle = new Rectangle(5, 7); // Width = 5, Height = 7

        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
    }
}