namespace OOP;
public class Person
{
    private string? _name;
    private int _age;
    internal static string? Password;
    
    public void SetName(string? name)
    {
        _name = name;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    public static void SetPassword(string? password)
    {
        Password = password;
    }

    public static void Pet(int choice)
    {
        switch (choice)
        {
            case 1 when Dog.Mood == 10:
                Console.WriteLine("Dog is too excited to be petted");
                break;
            case 1:
                Dog.Mood += 1;
                Console.WriteLine("You petted your dog, Its now happier");
                Console.WriteLine(Dog.Mood);
                break;
            case 2 when Cat.Mood == 10:
                Console.WriteLine("Cat doesn't want to to be petted");
                break;
            case 2:
                Cat.Mood += 1;
                Console.WriteLine("You petted your cat, you are unsure if the cat is happier or not");
                Console.WriteLine(Cat.Mood);
                break;
        }
    }
    public static void Feed(int choice)
    {
        switch (choice)
        {
            case 1 when Dog.Satiety == 10:
                Console.WriteLine("Dog doesn't want to eat");
                break;
            case 1:
                Dog.Satiety += 1;
                Console.WriteLine("You fed your dog, Its now less hungry");
                Console.WriteLine(Dog.Satiety);
                break;
            case 2 when Cat.Satiety == 10:
                Console.WriteLine("You really don't want to feed your cat");
                break;
            case 2:
                Cat.Satiety += 1;
                Console.WriteLine("You fed your cat, It wants more");
                Console.WriteLine(Cat.Satiety);
                break;
        }
    }
    public static void ToBed(int choice)
    {
        switch (choice)
        {
            case 1:
                Dog.Age += 1;
                Console.WriteLine("Your dog slept through the entire day");
                Console.WriteLine(Dog.Age);
                break;
            case 2:
                Cat.Age += 1;
                Console.WriteLine("Your cat was already sleeping, It slept through the entire day");
                Console.WriteLine(Cat.Age);
                break;
        }
    }

    public static void Rename(int choice , string? password)
    {
        
    }

    public static void ShowStats(int choice)
    {
        
    }
}