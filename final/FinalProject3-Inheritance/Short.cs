// a child class called Short
public class Short : Event
{
    private string _eventType;


    // calling the parent constructor using "base"!
    public Short(string title, string date, string eventType) : base(title, date)
    {
        _eventType = eventType;

    }

    public string GetEventType()
    {
        return _eventType;
    }

}