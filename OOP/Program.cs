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
var choice = 0;
try
{
    var temp = Convert.ToInt32(Console.ReadLine());
    if (temp != 1 && temp != 2) 
    {
        Console.WriteLine("Wrong input, please try again");
        goto TryAgain;
    }
    choice = Convert.ToInt32(temp);
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
Console.WriteLine("Now you can choose an action");
Again:
Console.WriteLine("1 for pet, 2 for feed, 3  for put to bed , 4 for rename , 5 for stats , 6 for exit");
try
{
    var choice2 = Convert.ToInt32(Console.ReadLine());
    switch (choice2)
    {
        case 1:
        {
            Person.Pet(choice);
            if (choice == 1)
            {
                Dog.Bark();
            }
            else
            {
               Cat.Bark(); 
            }
            goto Again;
        }
        case 2:
        {
            Person.Feed(choice);
            if (choice == 1)
            {
                Dog.Poop();
            }
            else
            {
                Cat.Poop(); 
            }
            goto Again;
        }
        case 3:
        {
            Person.ToBed(choice);
            if (choice == 1)
            {
                Dog.Kick();
            }
            else
            {
                Cat.Kick(); 
            }
            goto Again;
        }
        case 4:
        {
            Console.WriteLine("To change the name of your pet you need to type in your exact password");
            password = Console.ReadLine();
            Person.Rename(choice, password);
            goto Again;
        }
        case 5:
        {
            Person.ShowStats(choice);
            goto Again;
        }
        case 6:
        {
            Console.WriteLine("Thanks for using this program!");
            return;
        }
    }
}
catch (Exception)
{
    Console.WriteLine("You typed invalid input, please try again");
    goto Again;
}




    

