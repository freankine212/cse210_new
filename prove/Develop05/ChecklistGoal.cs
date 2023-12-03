using System;

public abstract class ChecklistGoal : Goal
{
    //attribbutteess
    private string _type = "Checklist Goal: ";
    private int _numberOfTimes;
    private int _bonusPoints;
    private bool _status;
    private int _count;

    public ChecklistGoal(string type, string name, string description, int points, int _numberOfTimes, int bonusPoints) : base(type,name,description,points)
    {
        _status = false;
        _numberOfTimes = numberOfTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberOfTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        _status = status;
        _numberOfTimes = numberOfTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public int GetTimes()
    {
        return _numberOfTimes;
    }
    public void SetTimes()
    {
        _count = _count+1;
    }
    public int GetCount()
    {
        return _count;
    }   
    public void SetCount()
    {
        
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public Boolean Finished()
    {
        return _status;
    }

    //Meathods
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }
    
    }
    public override void SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_count == _numberOfTimes)
        {
            _status = true;
            points = points + _bonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Nice work! You have earned {GetPoints()} points! Way to go dude!");
        }
    }
    
    
}