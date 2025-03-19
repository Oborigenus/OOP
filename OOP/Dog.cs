namespace OOP;
public class Dog : Animal
{
    private static string? _name;
    
    public static void CreateDog()
    {
        Console.WriteLine("Please choose a name for your dog");
        _name = Console.ReadLine();
        Age:
        try
        {
            Console.WriteLine("Please choose how old your dog is in days");
            Age = int.Parse(Console.ReadLine()!);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid age, please try again");
            goto Age;  
        }
        Satiety:
        try
        {
            Console.WriteLine("Please choose how hungry your dog is on the scale of 1-10");
            int satiety = int.Parse(Console.ReadLine()!);
            if (satiety > 10)
            {
                Console.WriteLine("You are not allowed have satiety to be more than 10");
                goto Satiety;
            }

            if (satiety < 1)
            {
                Console.WriteLine("You are not allowed have satiety to be less than 1");
                goto Satiety;
            }
            Satiety = satiety;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid satiety, please try again");
            goto Satiety;
        }
        
        Mood:
        try
        {
            Console.WriteLine("Please choose a mood for your dog on the scale of 1-10");
            var mood = int.Parse(Console.ReadLine()!);
            switch (mood)
            {
                case > 10:
                    Console.WriteLine("You are not allowed to have mood to be more than 10");
                    goto Mood;
                case < 1:
                    Console.WriteLine("You are not allowed to have mood to be less than 1");
                    goto Mood;
            }

            Mood = mood;
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid mood, please try again");
            goto Mood;
        }
        
        Console.WriteLine("Please choose a color for your dog");
        Color = Console.ReadLine();

        
    }
    
    public static void Bark()
    {
        
    }
    
    public static void Poop()
    {
        
    }
    
    public static void Kick()
    {
        
    }
    public void Rename(string password)
    {
        if (password != Person.Password) return;
        Console.WriteLine("Please choose a name for your cat");
        _name = Console.ReadLine();
    }
}