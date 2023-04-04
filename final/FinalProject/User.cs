public class User
{
    private string _name;
    List<Exercise> _allExercises = new List<Exercise>();
    List<string> _completedExercises = new List<string>();

    List<Routine> _routines = new List<Routine>();

    public User(string name)
    {
        _name = name;
    }

    public void DisplayCurrentWeekExercises()
    {}
    public void DisplayAllExercises()
    {
        Console.WriteLine("All exercises: ");

        int i = 1;
        foreach (Exercise exercise in _allExercises)
        {
            Console.WriteLine($"{i}. " + exercise.GetExerciseName());
            i++;
        }
        Console.WriteLine();
    }
    public void DisplayAllRoutines()
    {
        Console.WriteLine("Workout routines: ");

        int i = 1;
        foreach (Routine routine in _routines)
        {
            Console.WriteLine($"{i}. " + routine.GetRoutineName());
            i++;
        }
        Console.WriteLine();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetCompletedExercises()
    {
        string _stringRepresentation = "";
        foreach (string completedExercise in _completedExercises)
        {
            _stringRepresentation = _stringRepresentation + completedExercise + $"\n";
        }
        return _stringRepresentation;
    }
    public string GetAllExercises()
    {
        string _stringRepresentation = "";
        foreach (Exercise exercise in _allExercises)
        {
            _stringRepresentation = _stringRepresentation + exercise.GetStringRepresentation();
        }
        return _stringRepresentation;
    }
    public string GetRoutine()
    {
        string _stringRepresentation = "";
        foreach (Routine routine in _routines)
        {
            _stringRepresentation = _stringRepresentation + routine.GetStringRepresentation();
        }
        return _stringRepresentation;
    }
    public void AddExercise(Exercise exercise)
    {
        _allExercises.Add(exercise);
    }
    public void AddRoutine(Routine routine)
    {
        _routines.Add(routine);
    }
    public void AddCompletedExercise(string completedExerciseInfo)
    {
        _completedExercises.Add(completedExerciseInfo);
    }

    public Exercise GetExerciseByIndex(int num)
    {
        return _allExercises[num - 1];
    }
    public Routine GetRoutineByIndex(int num)
    {
        return _routines[num - 1];
    }

    public bool HasNoExercises()
    {
        if (!_allExercises.Any())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasNoRoutines()
    {
        if (!_routines.Any())
        {
            return true;
        }
        else
        {
            return false;
        }
    }   

    // public bool IsEmpty(List<Exercise> list)
    // {
    //     bool isEmpty = !list.Any();
    //     if(isEmpty)
    //     {
    //         // ...
    //     }  
    //     // if (list.Count == 0)
    //     // {
    //     //     return true;
    //     // }
    //     // else
    //     // {
    //     //     return false;
    //     // }
    // }

}