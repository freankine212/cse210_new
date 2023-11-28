using System;
using System.Diagnostics;

public class ReflectingActivity : Activity
{

    //Attributes
    private List<string> _promptsLIST = new List<string>
    {
        "Think of a time where you helped someone else",
        "Think of a time when you made it through something terrible",
        "Think of the last time you ate your moms cooking",
        "Think of a time when you and your dad shared a wonderful moment together",
        "Imagine a time when there was no conflict in your life"
    };
    
    private List<string> _questionsLIST = new List<string>
    {
        "Why did this mean that much to you?",
        "How did this make you feel?",
        "Did you want this feeling to last?",
        "How many times have you run through this scenario in your head?",
        "Would you ever want to change it?",
        "What is your favorite part of this memory?",
        "What motivated you to do this?"
    };

    private List<string> _useQuestionsLIST = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "This activity will help you to reflect on times that made you feel good or at peace";
    
    
    
    public ReflectingActivity(string activityNAME, int activityTIME) : base(activityNAME, activityTIME)
    {

    }
    // saw this cool little tidbit on stackoverflow, basically wanting to output the _description and this snippet can do that!
    public void GetActivityDESCRIPTION()
    {
        Console.WriteLine(_description);
    }

    public void Run()
    {

    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptsLIST.Count);
        return _promptsLIST[index];
    }

    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_useQuestionsLIST.Count);
        return _useQuestionsLIST[index];
    }

    public void DisplayPrompt(int seconds)
    {
        Console.WriteLine();  //insert blank line to start
        var prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            DisplayQuestions(seconds);
        }
    }

    public void DisplayQuestions(int seconds)
    {
        
        _useQuestionsLIST.AddRange(_questionsLIST); //creates a new list that can be destroyed each time.
        Spinner spinner = new Spinner();
        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        CountDown(8);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_useQuestionsLIST.Count != 0)
            {
                var question = GetRandomQuestion();
                Console.Write($"\n>> {question}  ");
                _useQuestionsLIST.Remove(question);  //removes question from list so it can not be used again
            }
            spinner.ShowSpinner();
        }
    timer.Stop();
    
    }
}