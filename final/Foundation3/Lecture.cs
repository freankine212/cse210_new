using System;

public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public string GetRoomHold()
    {
        return _capacity;
    }

    public string ReturnEventType()
    {
        return "Lecture";
    }

    public string GenerateDetailedLecture()
    {
        string detailed = GenerateStandard() + "\n";

        detailed += "Speaker: " + _speaker + "\n";
        detailed += "Room can hold: " + _capacity + " max people";
        return detailed;
    }

    public string GenerateShortLecture()
    {
        string shortLecture = "";
        string eventType = ReturnEventType();

        shortLecture += "Evnet Type: " + eventType + "\n";
        shortLecture += GenerateShort();
        return shortLecture;
    }
}