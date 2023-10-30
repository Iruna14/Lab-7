using System;

public interface IIdentifiable
{
    string Id { get; }
}

public interface IBirthable
{
    string Birthdate { get; }
}

public class Citizen : IIdentifiable, IBirthable
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Id { get; private set; }
    public string Birthdate { get; private set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();

        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable birthable = new Citizen(name, age, id, birthdate);

        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthdate);
    }
}
