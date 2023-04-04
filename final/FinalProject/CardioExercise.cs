public class CardioExercise: Exercise
{
    private int _minutesToComplete;
    private int _minutesCompleted;
    // private int _caloriesBurned;

    public CardioExercise(string name, string description, string muscleGroup): base(name, description, muscleGroup)
    {}
    public CardioExercise(string name, string description, string muscleGroup, int minutesCompleted, int minutesToComplete): base(name, description, muscleGroup)
    {
        _minutesCompleted = minutesCompleted;
        _minutesToComplete = minutesToComplete;
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
        Console.WriteLine($"{_name} ({_description}), {_muscleGroup} -- Minutes: {_minutesCompleted}/{_minutesToComplete}");
    }
    public override string GetStringRepresentation()
    {
        return $"CardioExercise,{_name},{_description},{_muscleGroup}\n";
    }
    public override string GetFullStringRepresentation()
    {
        return $"CardioExercise|{_name}|{_description}|{_muscleGroup}|{_minutesCompleted}|{_minutesToComplete}";
    }
    public override void RecordEvent()
    {
        if (_complete == true)
        {
            Console.WriteLine("The time for that exercise has already been completed.");
        }
        else
        {
            int minutes;
            Console.Write("How many minutes did you complete of this exercise? ");


            if (int.TryParse(Console.ReadLine(), out minutes))
            {
                _minutesCompleted += minutes;
            }
            else
            {
                Console.WriteLine("Not a valid input. Please try again.");
            }

            if (_minutesCompleted >= _minutesToComplete)
            {
                CompleteExercise();
            }
        }
    }
    public override void SetOtherInfo()
    {
        Console.Write("How many minutes will you do this exercise for? ");
    
        if (int.TryParse(Console.ReadLine(), out _minutesToComplete))
        {}
        else
        {
            Console.WriteLine("Not a valid input. Please try again.");
        }
    }
    public override void ResetExercise()
    {
        _complete = false;
        _minutesCompleted = 0;
    }
}