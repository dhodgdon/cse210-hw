public abstract class Exercise
{
    protected string _name;
    protected string _description;
    protected string _muscleGroup;
    protected bool _complete = false;

    public Exercise(string name, string description, string muscleGroup)
    {
        _name = name;
        _description = description;
        _muscleGroup = muscleGroup;
    }

    public string GetExerciseName()
    {
        return _name;
    }
    public abstract void DisplayExercise();
    public void CompleteExercise()
    {
        _complete = true;
        Console.WriteLine("Congratulations! You completed this exercise! ");
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public abstract string GetStringRepresentation();
    public abstract string GetFullStringRepresentation();
    public abstract void RecordEvent();
    public abstract void SetOtherInfo();
    public abstract void ResetExercise();
}