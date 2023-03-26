public class WeightedExercise: Exercise
{
    private int _weight;
    private int _repetitions;
    private int _sets;

    public WeightedExercise(string name, string description, string muscleGroup): base(name, description, muscleGroup)
    {}

    public override void DisplayExercise()
    {
        throw new NotImplementedException();
    }
    public override void CompleteExercise()
    {
        throw new NotImplementedException();
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}