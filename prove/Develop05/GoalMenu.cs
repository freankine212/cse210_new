using System;

public class GoalMenu
{

    // attribbutes

    private string _menu = $@"
    Welcome to your Goal menu
    ~~~~~~~~~~~~~~~~~~~~~~~~~
    1. Simple Goal (quick and painless)
    2. Eternal Goal (You're never gonna finish this, its just for your self)
    3. Checklist Goal (Need something to keep you going throughout the challenge?)
    4. Back to Start
    ~~~~~~~~~~~~~~~~~~~~~~~~~
    What type of goal do you want to create?  ";
        public string _goalInput;
        private int _goalChoice = 0;

    //metthods
    public int GoalChoice()
    //This will show the choices to the user
    {
        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;

                // This block catches any non integer values that are entered
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }


    
}