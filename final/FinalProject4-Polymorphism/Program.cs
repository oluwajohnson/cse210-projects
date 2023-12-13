using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Cycling cycling = new Cycling();
        string cycl = cycling.GetSummary();
        Console.WriteLine(cycl);

        Swimming swimming = new Swimming();
        string swim = swimming.GetSummary();
        Console.WriteLine(swim);

        Running running = new Running();
        string run = running.GetSummary();
        Console.WriteLine(run);
    }

}