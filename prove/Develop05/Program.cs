

using System;

class Program
{



    static void SaveFile(string filename, List<string> getResponse)
    {
        string fileName = $"{filename}.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            foreach (string response in getResponse)
            {

                outputFile.WriteLine($"Goal on this Date: {dateText}: {response}");

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


                Console.WriteLine($" {line}");

            }
            catch (System.IndexOutOfRangeException)
            {

                throw;
            }

        }

    }








    static void Main(string[] args)
    {


        int yourResponse = -1;
        List<AllGoals> allGoals = new List<AllGoals>();
        List<string> List_response = new List<string>();
        List<string> List_record = new List<string>();
        List<string> List_point = new List<string>();

        int point = 0;
        while (yourResponse != 6)
        {
            Console.WriteLine("Your point is " + point);
            Console.WriteLine(" ");
            Console.WriteLine("Menu Options:  ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            string Response = Console.ReadLine();

            yourResponse = int.Parse(Response);

            string answer1 = "";
            string answer2 = "";
            string answer3 = "";

            string answerf1 = "";
            string answerf2 = "";
            string answerf3 = "";

            string answerff1 = "";
            string answerff2 = "";
            string answerff3 = "";
            string answerff4 = "";
            string answerff5 = "";

            string attempt = "0";



            if (yourResponse == 1)
            {

                int goalResponse = -1;

                Console.WriteLine("Select a choice from the menu: " + yourResponse);
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");

                while (goalResponse != 4)
                {
                    string reply = Console.ReadLine();

                    goalResponse = int.Parse(reply);






                    if (goalResponse == 1)
                    {
                        Console.Write("What is the name of your goal? ");
                        answer1 = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        answer2 = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        answer3 = Console.ReadLine();

                        List_response.Add("Simple Goal:" + answer1 + "," + answer2 + "," + answer3);
                        List_record.Add(answer1);
                        List_point.Add(answer3);

                        Goal1 s1 = new Goal1(answer1, answer2, answer3);
                        allGoals.Add(s1);
                        goalResponse = 4;
                    }
                    if (goalResponse == 2)
                    {
                        Console.Write("What is the name of your goal? ");
                        answerf1 = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        answerf2 = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        answerf3 = Console.ReadLine();

                        List_response.Add("Eternal Goal:" + answerf1 + "," + answerf2 + "," + answerf3);
                        List_record.Add(answerf1);
                        List_point.Add(answerf3);
                        Goal2 s1 = new Goal2(answerf1, answerf2, answerf3);
                        allGoals.Add(s1);
                        goalResponse = 4;
                    }
                    if (goalResponse == 3)
                    {
                        Console.Write("What is the name of your goal? ");
                        answerff1 = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        answerff2 = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        answerff3 = Console.ReadLine();

                        Console.Write("How many times does this goal need to be accomplied for a bonus? ");
                        answerff4 = Console.ReadLine();
                        Console.Write("What is the bonus for accomplishing it that may times? ");
                        answerff5 = Console.ReadLine();

                        attempt = "0";

                        List_response.Add("Checklist Goal:" + answerff1 + "," + answerff2 + "," + answerff3 + "," + answerff5 + "," + answerff4 + "," + attempt);
                        List_record.Add(answerff1);
                        List_point.Add(answerff3);
                        Goal3 s1 = new Goal3(answerff1, answerff2, answerff4, attempt, answerff5);
                        allGoals.Add(s1);
                        goalResponse = 4;
                    }

                }

            }

            if (yourResponse == 2)
            {

                Console.WriteLine("Your goals are: ");
                foreach (AllGoals s in allGoals)
                {

                    string goalAnswer1 = s.GetgoalAnswer1();


                    string goal = s.GetGoal();

                    Console.WriteLine(goal);
                }
                Console.WriteLine(" ");

            }

            if (yourResponse == 3)
            {
                Console.Write("What will you name the file?  ");
                string respond1 = Console.ReadLine();
                SaveFile(respond1, List_response);

            }

            if (yourResponse == 4)
            {
                Console.Write("What is the file? ");
                string respond1 = Console.ReadLine();
                LoadFile(respond1);
                Console.Write(" ");

            }
            if (yourResponse == 5)
            {
                Console.WriteLine("Your goals are: ");
                foreach (string record in List_record)
                {

                    Console.WriteLine($" {record}");

                }
                Console.WriteLine(" ");
                string respond1 = Console.ReadLine();

                if (respond1 == "1")
                {
                    foreach (string score in List_point)
                    {
                        Console.WriteLine("Congratulations you have earned" + score[0]);
                        point = point + score[0];
                        Console.WriteLine("You now have " + point + " points");
                        Console.WriteLine("");


                    }

                }
                if (respond1 == "2")
                {
                    foreach (string score in List_point)
                    {
                        Console.WriteLine("Congratulations you have earned" + score[1]);
                        point = point + score[1];
                        Console.WriteLine("You now have " + point + " points");
                        Console.WriteLine("");


                    }


                }
                if (respond1 == "3")
                {
                    foreach (string score in List_point)
                    {
                        Console.WriteLine("Congratulations you have earned" + score[2]);
                        point = point + score[2];
                        Console.WriteLine("You now have " + point + " points");
                        Console.WriteLine("");


                    }
                }

            }




        }


    }

}