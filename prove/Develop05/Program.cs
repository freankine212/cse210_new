using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = new CultureInfo("en-us", false).TextInfo;

        GoalManagement goals = new GoalManagement();

        Console.Clear(); //Wipe console clean for resetting
        Console.Write("\n### Welcome to the Mission Board ###\n");

        Console.Write ($"\n### You Currently Have {goals.GetTotalPoints()} points! ###\n");
        //Call the main Menu
        MainMenu choice = new MainMenu();
        //Call in the Goal Menu
        GoalMenu goalChoice = new GoalMenu();

        int action = 0;
        while(action !=5)
        {
            action = choice.UserChoice();
            switch (action)
            {
             case 1:
                // Create New Goal
                Console.Clear();  // This will clear the console
                // Ask for user input (1-4)
                int goalInput = 0;
                while (goalInput != 5)
                // switch to goals menu
                {
                    goalInput = goalChoice.GoalChoice();
                    switch (goalInput)
                    {
                        case 1:
                            // Simple Goal
                            Console.WriteLine("What is the name of your goal?  ");
                            string name = Console.ReadLine();
                            name = textInfo.ToTitleCase(name);
                            Console.WriteLine("What is a short description of your goal?  ");
                            string description = Console.ReadLine();
                            description = textInfo.ToTitleCase(description);
                            Console.Write("What is the amount of points associated with this goal?  ");
                            int points = int.Parse(Console.ReadLine());
                            SimpleGoal simpleGoal = new SimpleGoal("Simple Goal:", name, description, points);
                            goals.AddGoal(simpleGoal);
                            goalInput = 5;
                            break;
                        case 2:
                            // Eternal Goal
                            Console.WriteLine("What is the name of your goal?  ");
                            name = Console.ReadLine();
                            name = textInfo.ToTitleCase(name);
                            Console.WriteLine("What is a short description of your goal?  ");
                            description = Console.ReadLine();
                            description = textInfo.ToTitleCase(description);
                            Console.Write("What is the amount of points associated with this goal?  ");
                            points = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal("Eternal Goal:", name, description, points);
                            goals.AddGoal(eternalGoal);
                            goalInput = 5;
                            break;
                        case 3:
                            // Checklist Goal
                            Console.WriteLine("What is the name of your goal?  ");
                            name = Console.ReadLine();
                            name = textInfo.ToTitleCase(name);
                            Console.WriteLine("What is a short description of your goal?  ");
                            description = Console.ReadLine();
                            description = textInfo.ToTitleCase(description);
                            Console.Write("What is the amount of points associated with this goal?  ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                            int numberTimes = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times?  ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                            goals.AddGoal(checklistGoal);
                            goalInput = 5;
                            break;
                        case 4:
                            //Exit
                            break;
                        default:
                            Console.WriteLine($"\nSorry the option you entered is not valid.");
                            break;

                        }
                    }
                    break;
                case 2:
                    //Listing Goals
                    Console.Clear();  // this wipes it again
                    Console.Write($"\n###You currently have {goals.GetTotalPoints()}###\n");
                    goals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear();  // This whipes it aghain
                    Console.Write($"\n### You currently have {goals.GetTotalPoints()} points! ###\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    Console.Clear();  // I like to clear the console
                    Console.Write($"\n### You currently have {goals.GetTotalPoints()} points! ###\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    // Quit
                    Console.WriteLine("\nThank you for using the Mission Board Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}      