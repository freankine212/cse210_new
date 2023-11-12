using System.Text;
using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome (back) to your Journal!");

        while (true)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save File");
            Console.WriteLine("4. Load File");
            Console.WriteLine("5. Quit");
            
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                {
                    Console.WriteLine("Randomizing topic today....");
                    string prompt= promptGenerator.GetPrompt(_prompt);
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Enter your journal entry: ");
                    string _entryText = Console.ReadLine();

                    Entry newEntry = new Entry(DateTime.Now, _entryText, prompt);
                    myJournal.AddEntry(newEntry);

                    Console.WriteLine("Entry saved!");
                    break;
                }
                case "2":
                Console.WriteLine("Journal Entries:");
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter file path to load entries from: ");
                    string filePathLoad = Console.ReadLine();
                    myJournal.LoadFromFile(filePathLoad);
                    Console.WriteLine("Entries loaded successfully!");
                    break;

                case "4":
                    Console.Write("Enter file path to save entries to: ");
                    string filePathSave = Console.ReadLine();
                    myJournal.SaveToFile(filePathSave);
                    Console.WriteLine("Entries saved successfully!");
                    break;

                case "5":
                    Console.WriteLine("Exiting. Goodbye and see you next time!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("No can do, please try again.");
                    break;
            
            }
        }
    }
}