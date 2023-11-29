using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void spinAnimation()
    {
        Console.Write("|");


        Thread.Sleep(1000);

        Console.Write("\b \b"); // Erase the + character
        Console.WriteLine("-"); // Replace it with the - character
    }


    static void countDown(int duration)
    {
        // Console.WriteLine("Duration is" + duration);
        int period = duration / 3;
        for (int i = period; i > 0; i--)
        {

            Console.Write(i);

            Thread.Sleep(1000);

            Console.Write("\b \b"); // Erase the + character
                                    // Console.Write("Done."); // Replace it with the - character


        }
    }

    static void quit(int duration)
    {
        ;
        for (int i = duration; i > 0; i--)
        {

            if (i == 0)
            {
                duration = 0;
            }

        }
    }


    static void Main(string[] args)
    {



        List<string> List_response = new List<string>();
        List<string> List_questions = new List<string> { "---Think of a time when you stood up for someone else---", "---Think of a time when you did something really difficult---", "---Think of a time when you helped someone in need---" };


        // Console.WriteLine("Welcome to the Journal Program!");
        // Console.WriteLine("Please select one of the follwing choices:  ");





        // int respond = Console.ReadLine();
        int yourResponse = -1;

        while (yourResponse != 5)
        {

            Console.WriteLine("Menu Options:  ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");

            string Response = Console.ReadLine();

            yourResponse = int.Parse(Response);



            if (yourResponse == 1)
            {

                Console.WriteLine("Welcome to the Breathing Activity");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");

                string session = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Get ready....");
                int myduration = 0;
                int duration = int.Parse(session);
                while (myduration != duration)
                {


                    for (int i = duration / 10; i > 0; i--)
                    {


                        Console.WriteLine("");
                        spinAnimation();
                        Console.Write("Breathe in...."); countDown(duration); Console.WriteLine("");
                        Console.Write("Now breathe out...."); countDown(duration);
                        Console.WriteLine("");
                        if (i == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Well done!!!");
                            Console.WriteLine("");
                            Console.WriteLine("You have completed another " + duration + " seconds of the Breathing Activity");
                            duration = 0;
                        }
                    }


                }

            }

            if (yourResponse == 2)
            {


                Console.WriteLine("Welcome to the Reflecting Activity");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");

                string session = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Get ready....");
                spinAnimation();
                Console.Write("");
                Console.WriteLine("Consider the follwoing prompt: ");
                Console.WriteLine("");
                Console.WriteLine(List_questions[0]);
                Console.WriteLine("");
                Console.WriteLine("When you have something in mind, press enter to continue ");
                string Response2 = Console.ReadLine();
                if (Response2 == "")
                {
                    Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
                    Console.Write("You may begin in...."); countDown(10); Console.WriteLine("");
                    Console.Clear();
                    int myduration = 0;
                    int duration = int.Parse(session);
                    while (myduration != duration)
                    {


                        for (int i = duration; i >= 0; i--)
                        {


                            Console.WriteLine("");

                            Console.Write(">How did you feel when it was completed? "); countDown(duration); Console.WriteLine("");
                            Console.Write(">What is your favourite thing about this experience? "); countDown(duration); Console.WriteLine("");
                            Console.Write(">Have you ever done anything like this before? "); countDown(duration); Console.WriteLine("");
                            // Console.Write(">How did you get started? "); countDown(duration); Console.WriteLine("");
                            // Console.Write(">How did you feel w hen it was complete? "); countDown(duration); Console.WriteLine("");
                            // Console.Write(">What made this time different than other times when you were not as successful? "); countDown(duration); Console.WriteLine("");
                            // Console.Write(i);
                            Console.WriteLine("");
                            if (i == 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Well done!!!");
                                Console.WriteLine("");
                                Console.WriteLine("You have completed another " + duration + " seconds of the Reflecting Activity");
                                duration = 0;
                            }
                        }


                    }
                }

            }


            if (yourResponse == 3)
            {


                Console.WriteLine("Welcome to the Listing Activity");
                Console.WriteLine("");
                Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");

                string session = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Get ready....");
                spinAnimation();
                Console.Write("");
                Console.WriteLine("List as many responses you can to the following prompt: ");
                Console.WriteLine("");
                Console.WriteLine(List_questions[0]);
                Console.WriteLine("");
                int duration = int.Parse(session);

                Console.Write("You may begin in...."); countDown(10); Console.WriteLine("");


                int myduration = 0;

                while (myduration != duration)
                {




                    for (int i = duration; i > 0; i--)
                    {


                        string session1 = Console.ReadLine();
                        List_response.Add(session1);


                        // foreach (string response in List_response)
                        // {

                        Console.WriteLine($"You listed {List_response.Count} items");

                        // }

                        Console.WriteLine("");
                        if (i == 0)


                            Console.WriteLine("");
                        Console.WriteLine("Well done!!!");
                        Console.WriteLine("");
                        Console.WriteLine("You have completed another " + duration + " seconds of the Listing Activity");
                        duration = 0;
                    }

                }


            }


        }




        if (yourResponse == 4)
        {

        }

    }



}

// EXTRA WORK
// Instead of type all the note name with is format, i made it easy to just tupe the note name without the format.