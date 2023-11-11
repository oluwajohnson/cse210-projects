using System;
using System.IO;

class Program
{

    static void SaveFile(string filename, List<string> getResponse)
    {
        string fileName = $"{filename}.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // // You can add text to the file with the WriteLine method
            // outputFile.WriteLine("This will be the first line in the file.");

            // // You can use the $ and include variables just like with Console.WriteLine
            // string color = "Blue";
            // outputFile.WriteLine($"My favorite color is {color}");

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            foreach (string response in getResponse)
            {

                outputFile.WriteLine($"Date: {dateText}- prompt: {response}");

            }


        }

    }
    static void LoadFile(string filename)
    {
        string fileName = $"{filename}.txt";


        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            try
            {
                string[] parts = line.Split(",");
                string Line = parts[0];

                Console.WriteLine($" {Line}");

            }
            catch (System.IndexOutOfRangeException)
            {

                throw;
            }

        }

    }

    static void Main(string[] args)
    {
        List<string> List_response = new List<string>();
        List<string> List_questions = new List<string> { "If I had one thing I could do over today, what would it be?", "What was the best part of my day?", "What was the strongest emotion I felt today?", "How did I see the hand of the Lord in my life today?" };


        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the follwing choices:  ");





        // int respond = Console.ReadLine();
        int yourResponse = -1;
        int first = 1;
        while (yourResponse != 5)
        {

            Console.WriteLine("Please select one of the follwing choices:  ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string Response = Console.ReadLine();

            yourResponse = int.Parse(Response);



            if (yourResponse == 1)
            {
                if (first == 1)
                {

                    first = 2;
                    Console.WriteLine(List_questions[0]);
                    string respond1 = Console.ReadLine();
                    List_response.Add(List_questions[0] + " " + respond1);
                    Console.WriteLine("What would you like to do?  ");
                }
                else
                {
                    first = 1;
                    Console.WriteLine(List_questions[3]);
                    string respond1 = Console.ReadLine();
                    List_response.Add(List_questions[3] + " " + respond1);
                    Console.WriteLine("What would you like to do?  ");
                }



            }
            if (yourResponse == 2)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                foreach (string response in List_response)
                {

                    Console.WriteLine($"Date: {dateText}- prompt: {response}");

                }


            }
            if (yourResponse == 3)
            {
                Console.WriteLine("What is the file? ");
                string respond1 = Console.ReadLine();
                LoadFile(respond1);

            }
            if (yourResponse == 4)
            {
                Console.WriteLine("What will you name the file?  ");
                string respond1 = Console.ReadLine();
                SaveFile(respond1, List_response);

            }
            if (yourResponse == 5)
            {

            }

        }


    }
}

// EXTRA WORK
// Instead of type all the note name with is format, i made it easy to just tupe the note name without the format.