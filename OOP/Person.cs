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
                Dog.Bark();
                break;
            case 1:
                Dog.Mood += 1;
                Console.WriteLine("You petted your dog, Its now happier");
                break;
            case 2 when Cat.Mood == 10:
                Console.WriteLine("Cat doesn't want to to be petted");
                Cat.Bark();
                break;
            case 2:
                Cat.Mood += 1;
                Console.WriteLine("You petted your cat, you are unsure if the cat is happier or not");
                break;
        }
    }
    public static void Feed(int choice)
    {
        switch (choice)
        {
            case 1 when Dog.Satiety == 10:
                Console.WriteLine("Dog doesn't want to eat");
                Dog.Poop();
                break;
            case 1:
                Dog.Satiety += 1;
                Console.WriteLine("You fed your dog, Its now less hungry");
                break;
            case 2 when Cat.Satiety == 10:
                Console.WriteLine("You really don't want to feed your cat");
                Cat.Poop();
                break;
            case 2:
                Cat.Satiety += 1;
                Console.WriteLine("You fed your cat, It wants more");
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
                Dog.Kick();
                break;
            case 2:
                Cat.Age += 1;
                Console.WriteLine("Your cat was already sleeping, It slept through the entire day");
                Cat.Kick();
                break;
        }
    }

    public static void Rename(int choice , string? name)
    {
        switch (choice)
        {
            case 1:
                Dog.Name = name;
                Console.WriteLine("You have successfully changed your dogs name");
                break;
            case 2:
                Cat.Name = name;
                Console.WriteLine("You have successfully changed your cats name");
                break;
        }
    }

    public static void ShowStats(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine($"your dog's name is {Dog.Name}, your dog's age is {Dog.Age}" +
                                  $", your dog's satiety is {Dog.Satiety}, your dog's mood is {Dog.Mood}" +
                                  $", your dog's color is {Dog.Color} ");
                break;
            case 2:
                Console.WriteLine($"your cat's name is {Cat.Name}, your dog's age is {Cat.Age}, " +
                                  $"your cat's satiety is {Cat.Satiety}, your cat's age is {Cat.Mood}" +
                                  $", your cat's color is {Cat.Color} ");                           
                break;
        }
    }
}