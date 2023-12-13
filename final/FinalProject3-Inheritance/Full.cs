// a child class called Full
public class Full : Event
{
    private string _eventType;
    private string _speakerName;
    private string _capacity;
    private string _email;
    private string _weatherStatement;

    // calling the parent constructor using "base"!
    public void FullLecturer(string title, string description, string date, string time, string address, string eventType, string speakerName, string capacity) : base(name)
    {
        _eventType = eventType;
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public void FullReception(string title, string description, string date, string time, string address, string eventType, string email) : base(name)
    {
        _eventType = eventType;
        _email = email;

    }
    public void FullReception(string title, string description, string date, string time, string address, string eventType, string weatherStatement) : base(name)
    {
        _eventType = eventType;
        _weatherStatement = weatherStatement;

    }

    public string GetEventType()
    {
        return _eventType;
    }
    public string GetSpeakerName()
    {
        return _speakerName;
    }
    public string GetCapacity()
    {
        return _capacity;
    }
    public string GetEmail()
    {
        return _email;
    }
    public string GetWeatherStatement()
    {
        return _weatherStatement;
    }
}