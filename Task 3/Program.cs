using System;

interface ICar
{
    string Model { get; }
    string UseBrakes();
    string PushGasPedal();
}

class Ferrari : ICar
{
    public string Model { get; } = "488-Spider";
    public string Driver { get; private set; }

    public Ferrari(string driver)
    {
        Driver = driver;
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the driver's name: ");
        string driverName = Console.ReadLine();
        Ferrari ferrari = new Ferrari(driverName);

        Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrakes()}/{ferrari.PushGasPedal()}/{ferrari.Driver}");
    }
}
