
namespace OOP;

public class Animal
{
    protected internal static int Age;
    protected internal static int Satiety;
    public static int Mood;
    protected static string? Color;

    public static void Bark()
    {
        Console.WriteLine("Bark");
    }

    public static void Poop()
    {
        Console.WriteLine("Shit");
    }

    public static void Kick()
    {
        Console.WriteLine("Kick");
    }
}