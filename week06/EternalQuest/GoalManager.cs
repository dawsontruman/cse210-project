using System;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        bool cont = true;
        while (cont)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine(); // blank line
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int selection;
            try
            {
                selection = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                continue;
            }
            // 1. Create New Goal
            if (selection == 1)
            {

            }
            // 2. List Goals
            else if (selection == 2)
            {

            }
            // 3. Save Goals
            else if (selection == 3)
            {

            }
            // 4. Load Goals
            else if (selection == 4)
            {

            }
            // 5. Record Event
            else if (selection == 5)
            {

            }
            // 6. Quit
            else if (selection == 6)
            {
                break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        // for now, just displays the current score
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {
        // calls RecordEvent() method for a goal
    }
    // ugh, files
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {
        
    }
}