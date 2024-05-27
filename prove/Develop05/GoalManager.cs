using System;

public class GoalManager
{
    int _score;
    private List<Goal> _goals;

    public GoalManager()
    {
        //_score=0
        _goals = new List<Goal>();
    }
    public void Start()
    {
        while (true){
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from menu: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice){
            case 1:
            ListGoalnames();
            CreateGoal();
            break;
            case 2:
            ListGoalDetails();
            break;
            case 3:
            SaveGoals();
            break;
            case 4:
            LoadGoals();
            break;
            case 5:
            RecordEvent();
            break;
            case 6:
            return;

            default:
            Console.WriteLine("Wrong choice, choose 1-6");
            break;

        }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");

    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Goal goal = _goals[i];
            string checkBox = " ";
            if (goal.IsComplete())
            {
                checkBox = "X";
            }
            Console.WriteLine($"{i + 1}. [{checkBox}] {goal.GetDetailString()}");
        }

    }
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int _goalIndex = Convert.ToInt32(Console.ReadLine());
        Goal goal = _goals[_goalIndex - 1];
        int points = goal.RecordEvent();
        _score += points;
        Console.WriteLine($"Congratulations, You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points");
    }
    public void SaveGoals()
    {
        string fileName = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");

            }
        }
    }
    public void LoadGoals()
    {
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = Convert.ToInt32(lines[0]);
        for (int i=1; i<lines.Count(); i++){
            string line = lines[i];
            string[] parts = line.Split(":");
            switch (parts[0])
            {
                case "SimpleGoal":
                    string[] parts2 = parts[1].Split(",");
                    _goals.Add(new SimpleGoal(parts2[0], parts2[1], Convert.ToInt32(parts2[2]), Convert.ToBoolean(parts2[3])));
                    break;

                case "EternalGoal":
                    string[] parts3 = parts[1].Split(",");
                    _goals.Add(new EternalGoal(parts3[0], parts3[1], Convert.ToInt32(parts3[2])));
                    break;

                case "ChecklistGoal":
                    string[] parts4 = parts[1].Split(",");
                    _goals.Add(new CheckListGoal(parts4[0], parts4[1], Convert.ToInt32(parts4[2]), Convert.ToInt32(parts4[3]), Convert.ToInt32(parts4[4]), Convert.ToInt32(parts4[5])));
                    break;
            }
        }
    }
    public void CreateGoal()
    {
        Console.Write("Which type of goals would you like to create? ");
        int _goalType = Convert.ToInt32(Console.ReadLine());
        switch (_goalType)
        {
            case 1:
                _goals.Add(new SimpleGoal(GetName(), GetDescription(), GetPoints()));
                break;
            case 2:
                _goals.Add(new EternalGoal(GetName(), GetDescription(), GetPoints()));
                break;
            case 3:
                _goals.Add(new CheckListGoal(GetName(), GetDescription(), GetPoints(), GetTarget(), GetBonus()));
                break;
            default:
                Console.WriteLine("Invalid selection, please enter a number 1-3.");
                break;
        }

    }
    public void ListGoalnames()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
    }

    private string GetName()
    {
        Console.Write("What is the name of your goal? ");
        return Console.ReadLine();
    }
    private string GetDescription()
    {
        Console.Write("What is the short description of it? ");
        return Console.ReadLine();
    }
    private int GetPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        return Convert.ToInt32(Console.ReadLine());
    }
    private int GetTarget()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        return Convert.ToInt32(Console.ReadLine());
    }
    private int GetBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        return Convert.ToInt32(Console.ReadLine());
    }
}