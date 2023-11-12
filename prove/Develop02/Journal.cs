using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;
    public  Entry entry;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = "myjournal.txt";
        try
        {
            StringBuilder sb = new StringBuilder();
            foreach (Entry entry in _entries)
            {
                sb.AppendLine($"{entry._date}|{entry._entryText}|{entry._promptText}");
            }
            File.WriteAllText(filename, sb.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving entries to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = "myjournal.txt";
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string text = parts[1];
                    string prompt = parts[2];
                    Entry entry = new Entry(date, text, prompt);
                    _entries.Add(entry);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading entries from file: {ex.Message}");
        }
    }
}