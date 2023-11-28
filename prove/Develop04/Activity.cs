using System;

public class Activity
{
    private string _activityNAME;
    private int _activityTIME;
    private string _message = "You can start in...";

    public Activity(string activityNAME, int activityTIME)
    {
        _activityNAME = activityNAME;
        _activityTIME = activityTIME;
    }
        public void GetActivityNAME()
    {
        Console.WriteLine($"Welcome to the {_activityNAME} Activity\n");
    }
    public void SetActivityName(string activityNAME)
    {
        _activityNAME = activityNAME;
    }
    public int GetActivityTIME()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTIME = userSeconds;
        return userSeconds;
    }
    public void SetactivityTIME(int activityTIME)
    {
        _activityTIME = activityTIME;
    }
 // Methods
    public void GetReady()
    {
        Console.Clear();
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerReady();
    }

    public void GetDone()
    {
        Spinner spinner = new Spinner();
        spinner.ShowSpinnerDone();
        Console.WriteLine($"\nYou have completed another {_activityTIME} seconds of the {_activityNAME} Activity!");
        spinner.ShowSpinner();
    }
     public void CountDown(int time)
    {
        Console.WriteLine();  //insert blank line to start
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");  // last prompt
    }


}