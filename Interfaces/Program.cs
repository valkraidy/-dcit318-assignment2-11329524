using Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Interfaces");
        IMovable mycar = new Car();
        IMovable mybicycle = new Bicycle();

        
        mycar.Move();
        mybicycle.Move();
    }
}