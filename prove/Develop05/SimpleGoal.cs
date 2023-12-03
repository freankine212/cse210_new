using System;

public abstract class SimpleGoal : Goal
{
        // Attributes
    private string _type = "Simple Goal:";
    private bool _status;

    // Constructors
    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override void SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public abstract void RecordGoalEvent(List<Goal> _goals)
    {
       _status = true;
       Console.WriteLine($"Nice work! You have earned {GetPoints()} points! Way to go dude!");
    }
}