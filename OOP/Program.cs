using OOP;
var person = new Person();
Console.WriteLine("Please enter your name");
var name = (Console.ReadLine());
person.SetName(name);
Console.WriteLine("Please enter your age");
try
{
    var age = Convert.ToInt32(Console.ReadLine());
    person.SetAge(age);
}
catch (Exception)
{
    Console.WriteLine("You tried to enter non-existent age, so your age will be automatically 1 years old");
    person.SetAge(1);
}
Console.WriteLine("Please enter your password");
var password = (Console.ReadLine());
person.SetPassword(password);
Console.WriteLine("Now you can create a dog or a cat");
TryAgain:
Console.WriteLine("To choose you must type 1 for a dog or 2 for a cat");
try
{
    var choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
        {
            var dog = new Dog();
            Dog.CreateDog();
            break;
        }
        case 2:
        {
            var cat = new Cat();
            Cat.CreateCat();
            break;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("You typed invalid input, please try again");
    goto TryAgain;
}




    

