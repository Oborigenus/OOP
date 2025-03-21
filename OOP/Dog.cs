namespace OOP;
public class Dog : Animal
{
    internal static string? Name;
    
    public static void CreateDog()
    {
        Console.WriteLine("Please choose a name for your dog");
        Name = Console.ReadLine();
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
        Console.WriteLine("Your dog is barking, It's now wants to play");
        Mood -= 1;
    }
    
    public static void Poop()
    {
        Console.WriteLine("Unfortunately, your dog pooped, It now wants to eat");
        Satiety -= 1;
    }
    
    public static void Kick()
    {
        Console.WriteLine("Dog is kicking because of excessive energy, nothing happened");
    }
}