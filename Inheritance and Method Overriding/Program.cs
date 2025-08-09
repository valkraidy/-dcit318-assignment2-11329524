using Inheritance_and_Method_Overriding;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inheritance and Method Overriding");
        Animal animal1 = new Animal();
        Dog dog1 = new Dog();
        Cat cat1 = new Cat();


        animal1.Makesound();
        dog1.Makesound();
        cat1.Makesound();

    }
}