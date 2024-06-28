using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _userScore = 0;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        LoadGoals();
        bool running = true;
        while (running)
        {
            Console.Clear();
        Console.WriteLine($"Your score: {_userScore}");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Create a new goal");
        Console.WriteLine("2. Record an event");
        Console.WriteLine("3. Show goals");
        Console.WriteLine("4. Save and Exit");
        Console.WriteLine("5. Clear progress");
        Console.WriteLine("Choose an option: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreateGoal();
                break;
            case "2":
                RecordEvent();
                break;
            case "3":
                ShowGoals();
                break;
            case "4":
                SaveGoals();
                running = false;
                break;
            case "5":
                ClearProgress();
                break;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
        }
    }


    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Daily Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new Simple(name, points));
                break;
            case "2":
                _goals.Add(new Daily(name, points));
                break;
            case "3":
                Console.Write("Enter goal target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new Checklist(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.Write("Select a goal to record: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= _goals.Count)
        {
            _userScore += _goals[index - 1].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    static void ShowGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey();
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_userScore);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _userScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    switch (parts[0])
                    {
                        case "Simple Goal":
                            _goals.Add(new Simple(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                            break;
                        case "Daily Goal":
                            _goals.Add(new Daily(parts[1], int.Parse(parts[2]), int.Parse(parts[3])));
                            break;
                        case "Checklist Goal":
                            _goals.Add(new Checklist(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                            break;
                    }
                }
            }
        }
    }

    static void ClearProgress()
    {
        _goals.Clear();
        _userScore = 0;
        if (File.Exists("goals.txt"))
        {
            File.Delete("goals.txt");
        }
        Console.WriteLine("Progress has been cleared. Press any key to return to the main menu.");
        Console.ReadKey();
    }
}