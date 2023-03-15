public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, bool complete, int points): base(name, description, points, complete)
    {}

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_complete}\n";
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
            IsComplete();
            return _points;
        }
    }
    // public override void CreateGoal()
    // {
    //     // Console.WriteLine("Which type of goal would you like to create? ");
    //     Console.WriteLine("What is the name of your goal? ");
    //     _name = Console.ReadLine();
    //     Console.WriteLine("What is a short description? ");
    //     _description = Console.ReadLine();
    //     Console.WriteLine("What is the amount of points associated with this goal? ");
    //     _points = int.Parse(Console.ReadLine());     
           
    // }
}