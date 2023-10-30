using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string mark = Console.ReadLine();
        int Mark = int.Parse(mark);

        string letter;
        if (Mark >= 90)
        {
            letter = "A";
        }
        else if (Mark >= 80)
        {
            letter = "B";
        }
        else if (Mark >= 70)
        {
            letter = "C";
        }
        else if (Mark >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // if(Mark.ToString().EndsWith("3")){
        if (Mark % 10 >= 7)
        {
            Console.WriteLine($"Your grade is: {letter}+");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}-");
        }
        if (Mark >= 70)
        {
            Console.WriteLine("Congratulations, you have passed");
        }
        else
        {

            Console.WriteLine("Please try again next time");
        }


    }
}