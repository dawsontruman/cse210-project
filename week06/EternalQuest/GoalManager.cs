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
        while (true)
        {
            Console.WriteLine(); // blank line
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
            while (true)
            {
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    continue;
                }
            }
            // 1. Create New Goal
            if (selection == 1)
            {
                CreateGoal();
            }
            // 2. List Goals
            else if (selection == 2)
            {
                ListGoalDetails();
            }
            // 3. Save Goals
            else if (selection == 3)
            {
                SaveGoals();
            }
            // 4. Load Goals
            else if (selection == 4)
            {
                LoadGoals();
            }
            // 5. Record Event
            else if (selection == 5)
            {
                // the user is given a list of their goals and selects a goal to modify
                ListGoalNames();
                Console.WriteLine("Enter the number of the goal you completed (or enter 0 to cancel): ");
                int i;
                while (true)
                {
                    try
                    {
                        i = int.Parse(Console.ReadLine());
                        if (i == 0)
                        {
                            break;
                        }
                        else
                        {
                            _goals[i - 1].RecordEvent();
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }
                }
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
        // used for "Record Event" option
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}: {goal.GetStringRepresentation()}");
            i += 1;
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string selection = Console.ReadLine();
            // 1.Simple Goal
            if (selection == "1")
            {
                Console.WriteLine("Enter a name for your new Simple Goal:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a description for your new Simple Goal:");
                string description = Console.ReadLine();

                int points = 0;
                while (true)
                {
                    Console.Write("Enter the number of points you will recieve for completing this goal: ");
                    try
                    {
                        points = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);
                break;
            }
            // 2. Eternal Goal
            else if (selection == "2")
            {
                Console.WriteLine("Enter the name of your new Eternal Goal: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a brief description of your new Eternal Goal: ");
                string description = Console.ReadLine();
                int points;
                while (true)
                {
                    Console.Write("Enter the number of points you will recieve each time you complete this goal: ");
                    try
                    {
                        points = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
                break;
            }
            // 3. Checklist Goal
            else if (selection == "3")
            {
                Console.WriteLine("Enter the name of your new Checklist Goal: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter a brief description of your new Checklist Goal: ");
                string description = Console.ReadLine();
                int points;
                int target;
                int bonus;
                while (true)
                {
                    Console.Write("Enter the number of points you will recieve each time you complete this goal: ");
                    try
                    {
                        points = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Enter the number of times you need to complete this goal to recieve a bonus: ");
                    try
                    {
                        target = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Enter the number of bonus points you will recieve if you meet the target: ");
                    try
                    {
                        bonus = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklist);
            }

            // repeat prompt if selection input is not one of the numbers
            else
            {
                continue;
            }
        }
    }
    public void RecordEvent()
    {
        // calls RecordEvent() method for a goal
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}