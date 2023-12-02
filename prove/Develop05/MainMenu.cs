using System;

public class MainMenu
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

        public string _userInput;
        private int _userChoice=0;

        //metthods
        public int UserChoice()
        {
            Console.Write(_menu);

            _userInput = Console.ReadLine();
            _userChoice = 0;
        }
}