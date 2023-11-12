using System.Text;
using System.IO;
using System;
using System.Collections.Generic;
public class Entry
{
    // start making the variables for Entry
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public Entry(DateTime date, string entryText, string promptText)
    {
        _date = date;
        _entryText = entryText;
        _promptText = promptText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText}\n{_entryText}\n");
    }
}