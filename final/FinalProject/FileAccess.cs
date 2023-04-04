public class FileAccess
{
    private string _userFile;
    private string _exerciseFile;
    private string _routineFile;

    public FileAccess(string username)
    {
        _userFile = $"{username}.txt";
        _exerciseFile = $"{username}Exercises.txt";
        _routineFile = $"{username}Routines.txt";
    }

    public void LoadAll(User user)
    {
        LoadUserWorkouts(user);
        LoadExercises(user);
        LoadRoutine(user);
    }
    public void LoadUserWorkouts(User user)
    {
        using (StreamReader sr = new StreamReader(_userFile))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                user.AddCompletedExercise(line);
                // string[] userDetails = line.Split(",");
                // string completedWorkout = userDetails[0];
                // string dateCompleted = userDetails[1];


                // DateTime = userDetails[1];
                // string _name = exerciseDetails[1];
                // string _description = exerciseDetails[2];
                // string _muscleGroup = exerciseDetails[3];
                // int _points = int.Parse(exerciseDetails[3]);

            }
        }
    }
    public void LoadExercises(User user)
    {
        using (StreamReader sr = new StreamReader(_exerciseFile))
        {
            // _totalPoints = int.Parse(sr.ReadLine());
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] exerciseDetails = line.Split(",");
                string exerciseType = exerciseDetails[0];
                string _name = exerciseDetails[1];
                string _description = exerciseDetails[2];
                string _muscleGroup = exerciseDetails[3];
                // int _points = int.Parse(exerciseDetails[3]);

                switch (exerciseType)
                {
                    case "CardioExercise":
                    // bool _complete = bool.Parse(goalDetails[4]);
                    CardioExercise ce = new CardioExercise(_name, _description, _muscleGroup);
                    user.AddExercise(ce);
                    break;

                    case "WeightedExercise":
                    WeightedExercise we = new WeightedExercise(_name, _description, _muscleGroup);
                    user.AddExercise(we);
                    break;

                    // case "ChecklistGoal":
                    // int _bonus = int.Parse(goalDetails[4]);
                    // int _eventsToComplete = int.Parse(goalDetails[5]);
                    // int _eventsCompleted = int.Parse(goalDetails[6]);   
                    // ChecklistGoal cg = new ChecklistGoal(_name, _description, false, _points, _bonus, _eventsToComplete, _eventsCompleted);
                    // _goals.Add(cg);
                    // break;
                }
            }
        }
    }
    public void LoadRoutine(User user)
    {
        using (StreamReader sr = new StreamReader(_routineFile))
        {
            // _totalPoints = int.Parse(sr.ReadLine());
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] routineDetails = line.Split("+");
                string routineName = routineDetails[0];
                string routineDescription = routineDetails[1];
                Routine r = new Routine(routineName, routineDescription);
                user.AddRoutine(r);

                string[] exercises = routineDetails[2].Split("=");

                foreach (string exercise in exercises)
                {
                    string[] exerciseDetails = exercise.Split("|");
                    string exerciseType = exerciseDetails[0];
                    string _name = exerciseDetails[1];
                    string _description = exerciseDetails[2];
                    string _muscleGroup = exerciseDetails[3];
                    

                    // string[]  = exerciseDetails[2];
                    // string _muscleGroup = exerciseDetails[3];
                    // int _points = int.Parse(exerciseDetails[3]);

                    switch (exerciseType)
                    {
                        case "CardioExercise":
                        // bool _complete = bool.Parse(goalDetails[4]);
                        int _minutesCompleted = int.Parse(exerciseDetails[4]);
                        int _minutesToComplete = int.Parse(exerciseDetails[5]);
                        CardioExercise ce = new CardioExercise(_name, _description, _muscleGroup, _minutesCompleted, _minutesToComplete);
                        // user.AddExercise(ce);
                        r.AddExerciseToRoutine(ce);
                        break;

                        case "WeightedExercise":
                        int _weight = int.Parse(exerciseDetails[4]);
                        int _setsCompleted = int.Parse(exerciseDetails[5]);
                        int _setsToComplete = int.Parse(exerciseDetails[6]);
                        int _repetitionsToComplete = int.Parse(exerciseDetails[7]);
                        WeightedExercise we = new WeightedExercise(_name, _description, _muscleGroup, _weight, _setsCompleted, _setsToComplete, _repetitionsToComplete);
                        // user.AddExercise(we);
                        r.AddExerciseToRoutine(we);
                        break;

                        // case "ChecklistGoal":
                        // int _bonus = int.Parse(goalDetails[4]);
                        // int _eventsToComplete = int.Parse(goalDetails[5]);
                        // int _eventsCompleted = int.Parse(goalDetails[6]);   
                        // ChecklistGoal cg = new ChecklistGoal(_name, _description, false, _points, _bonus, _eventsToComplete, _eventsCompleted);
                        // _goals.Add(cg);
                        // break;
                    }
                }
            }
        }
    }
    public void SaveUserWorkouts(User user, string workoutName, DateTime currentTime)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFile))
        {
            outputFile.Write(user.GetCompletedExercises());
        }
    }
    public void SaveExercises(User user)
    {
        using (StreamWriter outputFile = new StreamWriter(_exerciseFile))
        {
            outputFile.Write(user.GetAllExercises());
        }
    }
    public void SaveRoutines(User user)
    {
        using (StreamWriter outputFile = new StreamWriter(_routineFile))
        {
            outputFile.Write(user.GetRoutine());

            // outputFile.WriteLine(GetPoints());
            // outputFile.Write(GetAllStringRepresentations());
        }
    }
}