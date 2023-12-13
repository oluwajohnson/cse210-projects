// a child class called Standard
public class Standard : Event
{


    // calling the parent constructor using "base"!
    public Standard(string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {

    }


}