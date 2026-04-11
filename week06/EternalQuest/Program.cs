using System;
// I Add some functionality to the Goal Manager. Now it shows a spinner when loading 
// between functions and then clears the screen.
// It also shows a random motivational phrase when you quit.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}