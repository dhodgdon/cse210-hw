using System.Linq;
public class User
{
    int _totalPoints;
    string _level;
    List<Goal> _goals = new List<Goal>();

    public User()
    {
        _totalPoints = 0;
        _level = "Apprentice";
    }
    public User(int points)
    {
        _totalPoints = points;
    }
    public int GetPoints()
    {
        return _totalPoints;
    }
    public string GetLevel()
    {
        return _level;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine();
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The goals are: ");
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{counter}. ");
            goal.DisplayGoal();
            counter++;
        }
        Console.WriteLine();
    }

    private string GetAllStringRepresentations()
    {
        string _stringRepresentation = "";
        foreach (Goal goal in _goals)
        {
            _stringRepresentation = _stringRepresentation + goal.GetStringRepresentation();
        }
        return _stringRepresentation;
    }
    public void Save()
    {
        string filename = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(GetPoints());
            outputFile.Write(GetAllStringRepresentations());
        }
    }

    public void Load()
    {
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            _totalPoints = int.Parse(sr.ReadLine());
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] goalDetails = line.Split(",");
                string goalType = goalDetails[0];
                string _name = goalDetails[1];
                string _description = goalDetails[2];
                int _points = int.Parse(goalDetails[3]);

                switch (goalType)
                {
                    case "SimpleGoal":
                    bool _complete = bool.Parse(goalDetails[4]);
                    SimpleGoal sg = new SimpleGoal(_name, _description, _complete, _points);
                    _goals.Add(sg);
                    break;

                    case "EternalGoal":
                    EternalGoal eg = new EternalGoal(_name, _description, false, _points);
                    _goals.Add(eg);
                    break;

                    case "ChecklistGoal":
                    int _bonus = int.Parse(goalDetails[4]);
                    int _eventsToComplete = int.Parse(goalDetails[5]);
                    int _eventsCompleted = int.Parse(goalDetails[6]);   
                    ChecklistGoal cg = new ChecklistGoal(_name, _description, false, _points, _bonus, _eventsToComplete, _eventsCompleted);
                    _goals.Add(cg);
                    break;
                }
            }
        }
    }
    public void AddPoints()
    {
        DisplayGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int num = int.Parse(Console.ReadLine());

        _totalPoints += _goals[num-1].RecordEvent();
    }
    public void DeleteGoal()
    {
        int lineNum = DisplayGoalNames();

        Console.WriteLine($"{lineNum}. All goals");


        Console.Write("Which goal would you like to delete? ");
        int num = int.Parse(Console.ReadLine());

        if (_goals.Count() >= num && num > 0)
        {
            _goals.RemoveAt(num - 1);
        }
        else if (num == _goals.Count() + 1)
        {
            _goals.Clear();
        }
        else
        {
            Console.WriteLine("Invalid response.");
        }
    }
    private int DisplayGoalNames()
    {
        int lineNum = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{lineNum}. {goal.GetName()}");
            lineNum++;
        }
        return lineNum;
    }
}