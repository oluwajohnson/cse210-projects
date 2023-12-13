using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Standard standard = new Standard("Brigham", "234");
        string title = standard.GetTitle();
        string description = standard.GetDescription();
        string date = standard.GetDate();
        string address = standard.GetAddress();

        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(date);
        Console.WriteLine(address);


    }

}