public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, bool complete, int points): base(name, description, points, complete)
    {}

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_name},{_description},{_points}\n";
    }
    public override int RecordEvent()
    {
        return _points;
    }
}