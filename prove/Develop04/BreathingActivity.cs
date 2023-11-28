using System;

public class BreathingActivity : Activity
{
    //have the user breathe in, hold, exhale
    private string _messageOne = "Inhale...";
    private string _messageTwo = "Hold it in...";
    private string _messageThree = "Now exhale...";
    private string _description = "This activity will help you to relax and recenter yourself by breathing in and out slowly. Focus only on your breathing.";
 
    public BreathingActivity( string activityNAME, int activityTIME) : base(activityNAME, activityTIME)
    {

    }

    public void GetActivityDESCRIPTION()
    {
        Console.WriteLine(_description);
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine(); //make it blank for beginning purposes
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine(); //make blank for beginning purposes
            for (int i=4; i >0; i--)
            {
                Console.Write($"{_messageOne}{i}");
                Thread.Sleep(500);
                string blank = new string('\b', (_messageOne.Length +2)); //Make the line be overwritten
                Console.Write(blank);
                secondsTimer +=1;
            }
            Console.WriteLine($"{_messageOne} "); // final prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_messageTwo}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_messageTwo.Length + 2));  // Make the line be overwritten
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_messageTwo}  ");  // final prompt
            for (int i = 6; i > 0; i--)
            {
                Console.Write($"{_messageThree}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_messageThree.Length + 2));  // make the line be overwritten
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.WriteLine($"{_messageThree}  ");  // final prompt
        }
    }
}