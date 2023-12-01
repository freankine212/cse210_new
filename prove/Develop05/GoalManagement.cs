using System;
using System.IO;

public class GoalManagement
{
        //attribbutes
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

            //constructors
    public GoalManagement()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    } 
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints+=bonusPoints;
    }

    public void ListGoals()
    {
        if (_goals.Count()>0)
        {
            Console.WriteLine("\nYour entered goals are:");

            int index = 1;
            //make a loop through the goals
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYoU dOn'T hAvE anY GoAls");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhat did you do? Tell me, what did you do?!?! ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n@*@*@*@*@*@*@*@~~ WOOOOOO! YOU ROCK! YOU HAVE {GetTotalPoints} POINTS! KEEP IT UP! ~~@*@*@*@*@*@*@*@");
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat do you want to save this goal file as? ex: thesegoals.txt or mygoals.txt");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            
            //we want ot read the first line of hte file for the total points
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);

            //move on from t he first line of text file to read the goals
            readText = readText.Skip(1).ToArray();
            
            //loop through the file for the goals
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries [1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);
            
            }

            if (entries[0] == "Simple Goal: ")
            {
                SimpleGoal simpleGoal = new SimpleGoal(type, name, description, points, status);
                AddGoal(simpleGoal);
            }

            if (entries[0] == "Eternal Goal: ")
            {
                EternalGoal eternalGoal = new EternalGoal(type, name, description, points, status);
                AddGoal(eternalGoal);
            }

            if (entries[0] == "Checklist Goal: ")
            {
                int numberTimes = int.Parse(entries[5]);
                int bonusPoints = int.Parse(entries[6]);
                int counter = int.Parse(entries[7]);
                ChecklistGoal checklistGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                AddGoal(checklistGoal);
            }
        }
    }
}