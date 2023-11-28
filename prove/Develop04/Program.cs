using System;

class Program
{
    static void Main(string[] args)
    {
    // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        //Call Choices
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityNAME();
                    breathing.GetActivityDESCRIPTION();
                    seconds = breathing.GetActivityTIME();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetActivityNAME();
                    reflecting.GetActivityDESCRIPTION();
                    seconds = reflecting.GetActivityTIME();
                    reflecting.GetReady();
                    reflecting.DisplayPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetActivityNAME();
                    listing.GetActivityDESCRIPTION();
                    seconds = listing.GetActivityTIME();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Quite
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }


    }

}