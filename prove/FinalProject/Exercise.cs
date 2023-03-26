public abstract class Exercise
{
    protected string _name;
    protected string _description;
    protected string _muscleGroup;

    public Exercise(string name, string description, string muscleGroup)
    {
        _name = name;
        _description = description;
        _muscleGroup = muscleGroup;
    }

    public abstract void DisplayExercise();
    public abstract void CompleteExercise();
    public abstract string GetStringRepresentation();
}