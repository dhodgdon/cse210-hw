public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;

    public Goal(string name, string description, int points, bool complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _complete = false;
    }

    public virtual void DisplayGoal()
    {
        if (_complete == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_description})");
    }
    public abstract string GetStringRepresentation();
    public virtual bool IsComplete()
    {
        return _complete = true;
    }
    public abstract int RecordEvent();
    // public virtual void CreateGoal()
    // {
    //     // Console.WriteLine("Which type of goal would you like to create? ");
    //     Console.WriteLine("What is the name of your goal? ");
    //     _name = Console.ReadLine();
    //     Console.WriteLine("What is a short description? ");
    //     _description = Console.ReadLine();
    //     Console.WriteLine("What is the amount of points associated with this goal? ");
    //     _points = int.Parse(Console.ReadLine());        
    // }
    public string GetName()
    {
        return _name;
    }
}