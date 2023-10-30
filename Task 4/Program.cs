using System;
using System.Linq;

public class Smartphone
{
    private string[] phoneNumbers;
    private string[] websites;

    public Smartphone(string phoneNumbers, string websites)
    {
        this.phoneNumbers = phoneNumbers.Split();
        this.websites = websites.Split();
    }

    public void CallNumbers()
    {
        foreach (string number in phoneNumbers)
        {
            if (long.TryParse(number, out _))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }

    public void BrowseWeb()
    {
        foreach (string website in websites)
        {
            if (website.All(char.IsLetterOrDigit) && website.Contains("."))
            {
                Console.WriteLine($"Browsing: {website}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter phone numbers separated by spaces:");
        string phoneNumbers = Console.ReadLine();

        Console.WriteLine("Enter websites separated by spaces:");
        string websites = Console.ReadLine();

        // Create a Smartphone object
        Smartphone smartphone = new Smartphone(phoneNumbers, websites);

        // Perform the operations
        smartphone.CallNumbers();
        smartphone.BrowseWeb();
    }
}

