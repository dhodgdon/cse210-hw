public class WeightedExercise: Exercise
{
    private int _weight;
    private int _repetitionsToComplete;
    // private int _repetitionsCompleted;
    private int _setsToComplete;
    private int _setsCompleted;

    public WeightedExercise(string name, string description, string muscleGroup): base(name, description, muscleGroup)
    {}
    public WeightedExercise(string name, string description, string muscleGroup, int weight, int setsCompleted, int setsToComplete, int repetitionsToComplete): base(name, description, muscleGroup)
    {
        _weight = weight;
        _setsCompleted = setsCompleted;
        _setsToComplete = setsToComplete;
        _repetitionsToComplete = repetitionsToComplete;
    }

    public override void DisplayExercise()
    {
        if (_complete == true)
        {
            Console.Write("[X] ");
        }
        else
        {
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_name} ({_description}), {_muscleGroup} -- {_weight} lbs., Sets: {_setsCompleted}/{_setsToComplete}, Reps per set: {_repetitionsToComplete}");
    }
    public override string GetStringRepresentation()
    {
        return $"WeightedExercise,{_name},{_description},{_muscleGroup}\n";
    }
    public override string GetFullStringRepresentation()
    {
        return $"WeightedExercise|{_name}|{_description}|{_muscleGroup}|{_weight}|{_setsCompleted}|{_setsToComplete}|{_repetitionsToComplete}";
    }
    public override void RecordEvent()
    {
        if (_complete == true)
        {
            Console.WriteLine("The reps for that exercise have already been completed.");
        }
        else
        {
            _setsCompleted++;

            if (_setsCompleted == _setsToComplete)
            {
                CompleteExercise();
            }
            // if (_setsCompleted < _setsToComplete)
            // {
            //     return _points;
            // }
            // else
            // {
            //     IsComplete();
            //     return _points + _bonus;
            // }
        }
    }
    public override void SetOtherInfo()
    {
        Console.Write("How much weight will you use for this exercise? (lbs.) ");
    
        if (int.TryParse(Console.ReadLine(), out _weight))
        {}
        else
        {
            Console.WriteLine("Not a valid input. Please try again.");
        }


        Console.Write("How many sets will you accomplish for this exercise? ");

        if (int.TryParse(Console.ReadLine(), out _setsToComplete))
        {}
        else
        {
            Console.WriteLine("Not a valid input. Please try again.");
        }


        Console.Write("How many reps will you accomplish for this exercise? ");

        if (int.TryParse(Console.ReadLine(), out _repetitionsToComplete))
        {}
        else
        {
            Console.WriteLine("Not a valid input. Please try again.");
        }
    }
    public override void ResetExercise()
    {
        _complete = false;
        _setsCompleted = 0;
    }
}