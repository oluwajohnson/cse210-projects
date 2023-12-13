using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        string title = "";
        string description = "";
        string date = "";
        string address = "";
        string eventType = "";
        string speakerName = "";
        string capacity = "";
        string email = "";
        string weatherStatement = "";

        Standard standard = new Standard("Graduation", "College Student Graduation", "20/12/2023", "BYU Garden");
        title = standard.GetTitle();
        description = standard.GetDescription();
        date = standard.GetDate();
        address = standard.GetAddress();

        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(date);
        Console.WriteLine(address);

        Full full = new Full("Graduation", "College Student Graduation", "20/12/2023", "BYU Garden");
        title = full.GetTitle();
        description = full.GetDescription();
        date = full.GetDate();
        address = full.GetAddress();
        eventType = full.GetEventType();
        speakerName = full.GetSpeakerName();
        capacity = full.GetCapacity();
        email = full.GetEmail();
        weatherStatement = full.GetWeatherStatement();

        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(date);
        Console.WriteLine(address);
        Console.WriteLine(eventType);
        Console.WriteLine(speakerName);
        Console.WriteLine(capacity);
        Console.WriteLine(email);
        Console.WriteLine(weatherStatement);



        Short short = new Short("Graduation", "College Student Graduation", "20/12/2023", "BYU Garden");
        title = short.GetTitle();
        description = short.GetDescription();
        date = short.GetDate();
        address = short.GetAddress();
        eventType = short.GetEventType();

        Console.WriteLine(title);
        Console.WriteLine(description);
        Console.WriteLine(date);
        Console.WriteLine(address);
        Console.WriteLine(eventType);

    }

}