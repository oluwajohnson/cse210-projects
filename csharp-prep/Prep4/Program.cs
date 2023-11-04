using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a number or 0 to discontinue: ");
        int yourNumber = -1;
        while (yourNumber != 0)
        {
            Console.Write("Enter a number ");

            string userResponse = Console.ReadLine();
            yourNumber = int.Parse(userResponse);


            if (yourNumber != 0)
            {
                numbers.Add(yourNumber);
            }
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {

                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}