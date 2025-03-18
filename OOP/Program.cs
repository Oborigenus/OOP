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
Person.SetPassword(password);
Console.WriteLine("Now you can create a dog or a cat");
TryAgain:
Console.WriteLine("To choose you must type 1 for a dog or 2 for a cat");
var choice = Convert.ToInt32(Console.ReadLine());
try
{
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
Console.WriteLine("Now you can choose an action for your pet");
Again:
Console.WriteLine("1 for pet, 2 for feed, 3  for put to bed , 4 for rename , 5 for stats");
try
{
    var choice2 = Convert.ToInt32(Console.ReadLine());
    switch (choice2)
    {
        case 1:
        {
            Person.Pet(choice);
            goto Again;
        }
        case 2:
        {
            Person.Feed(choice);
            goto Again;
        }
        case 3:
        {
            Person.ToBed(choice);
            goto Again;
        }
        case 4:
        {
            Person.Pet(choice);
            goto Again;
        }
        case 5:
        {
            if (choice == 1)
            {
                Console.WriteLine("You choose a dog or a cat");
            }
            break;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("You typed invalid input, please try again");
    goto Again;
}




    

