using System;

class Program
{
    static void Main(string[] args)
    {



        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        string myfirstName = char.ToUpper(firstName.First()) + firstName.Substring(1).ToLower();
        string mylastName = char.ToUpper(lastName.First()) + lastName.Substring(1).ToLower();

        Console.Write($"Your name is {mylastName}, {myfirstName} {mylastName}.");

    }
}