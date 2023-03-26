public class Routine
{
    private string _name;
    private string _description;
    List<Exercise> _exercises = new List<Exercise>();

    public Routine(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayRoutine()
    {}
    public void CreateRoutine()
    {}
}