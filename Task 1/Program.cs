using System;

public interface IPerson
{
    string Name { get; }
    int Age { get; }
}

public class Citizen : IPerson
{
    public string Name { get; }
    public int Age { get; }

    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the age:");
        int age = int.Parse(Console.ReadLine());

    
        IPerson person = new Citizen(name, age);

        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}
