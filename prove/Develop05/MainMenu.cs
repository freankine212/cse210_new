using System;

public class MainMenu
{

    // attribbutes

    private string _menu = $@"
    Welcome to your Goal menu
    ~~~~~~~~~~~~~~~~~~~~~~~~~
    1. New Goal Here
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Goal Event
    6. Quit
    ~~~~~~~~~~~~~~~~~~~~~~~~~
    What do you wanna do: ";

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