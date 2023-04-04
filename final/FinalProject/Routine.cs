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
    {
        Console.WriteLine($"Exercises in {_name}: ");

        int i = 1;
        foreach (Exercise exercise in _exercises)
        {
            // Console.WriteLine($"{i}. " + exercise.GetExerciseName());
            Console.Write($"{i}. ");
            exercise.DisplayExercise();
            i++;
        }
    }
    public void CreateRoutine()
    {}
    public void AddExerciseToRoutine(Exercise exercise)
    {
        Exercise e = exercise;
        _exercises.Add(e);
    }
    public string GetRoutineName()
    {
        return _name;
    }
    public string GetStringRepresentation()
    {
        string _stringRepresentation = $"{_name}+{_description}+";
        foreach (Exercise exercise in _exercises)
        {
            if (exercise != _exercises.Last())
            {
                _stringRepresentation += exercise.GetFullStringRepresentation() + "=";
            }
            else
            {
                _stringRepresentation += exercise.GetFullStringRepresentation();
            }
        }

        return _stringRepresentation + $"\n";
    }
    public void CompleteExerciseByIndex(int num)
    {
        _exercises[num - 1].RecordEvent();
    }
    public bool IsRoutineComplete()
    {

        bool isComplete;
        int count = 0;

        foreach (Exercise exercise in _exercises)
        {
            if (!exercise.IsComplete())
            {
                count++;
            }
        }
        if (count > 0)
        {
            isComplete = false;
        }
        else
        {
            isComplete = true;
        }
        return isComplete;
    }
    public void ResetRoutine()
    {
        foreach (Exercise exercise in _exercises)
        {
            exercise.ResetExercise();
        }
    }

    // public bool IsEmpty()
    // {
    //     if (!_exercises.Any())
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
    // }
}