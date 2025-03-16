using OOP;
Person person = new Person();
Console.WriteLine("Please enter the name your name");
string name = (Console.ReadLine());
person.SetName(name);
Console.WriteLine("Please enter the age your age");
try
{
    int age = Convert.ToInt32(Console.ReadLine());
    person.SetAge(age);
}
catch (Exception)
{
    Console.WriteLine("You tried to enter non-existent age, so your age will be automatically 1 years old");
    person.SetAge(1);
}





    

