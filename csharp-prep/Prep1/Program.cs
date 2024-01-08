using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your first name. ");
        string NameFirst = Console.ReadLine();
        Console.WriteLine("Please enter your last name. ");
        string NameLast = Console.ReadLine();
        Console.WriteLine($"Your name is {NameFirst + " " + NameLast}");

    }
}