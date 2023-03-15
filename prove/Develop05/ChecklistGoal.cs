public class ChecklistGoal : Goal
{
    int _bonus;
    int _eventsToComplete;
    int _eventsCompleted;
    public ChecklistGoal(string name, string description, bool complete, int points, int bonus, int eventsToComplete): base(name, description, points, complete)
    {
        _bonus = bonus;
        _eventsToComplete = eventsToComplete;
        _eventsCompleted = 0;
    }
    public ChecklistGoal(string name, string description, bool complete, int points, int bonus, int eventsToComplete, int eventsCompleted): base(name, description, points, complete)
    {
        _bonus = bonus;
        _eventsToComplete = eventsToComplete;
        _eventsCompleted = eventsCompleted;
    }

    public override void DisplayGoal()
    {
        if (_complete == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_description}) -- Currently completed: {_eventsCompleted}/{_eventsToComplete}");
    }
    public override bool IsComplete()
    {
        if (_eventsCompleted == _eventsToComplete)
        {
            _complete = true;
        }
        return _complete;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_bonus},{_eventsToComplete},{_eventsCompleted}\n";
    }
    public override int RecordEvent()
    {
        if (_complete == true)
        {
            Console.WriteLine("That goal has already been completed.");
            return 0;
        }
        else
        {
            _eventsCompleted++;

            if (_eventsCompleted < _eventsToComplete)
            {
                return _points;
            }
            else
            {
                IsComplete();
                return _points + _bonus;
            }
        }
    }
}