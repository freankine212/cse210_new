using System;

public abstract class Goal
{
    //attribbutes
    private string _type;
    private string _name;
    private string _description;
    private int _points;

    //constructors
    public Goal()
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetType()
    {
        return _type;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }


    //methods
    public abstract void ListGoal(int i);
    public abstract void SaveGoal();
    public abstract void LoadGoal();
    public abstract void RecordGoalEvent();
}