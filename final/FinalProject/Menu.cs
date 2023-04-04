public class Menu
{
    // private string _username;
    User user1 = new User("user");
    FileAccess fileAccess = new FileAccess("user");
    public Menu()
    {
        // _username = "username";
    }
    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Workout Program! Get ready to become large of stature!");
        // Console.Write("\n\nWhat is your username? ");
        // _username = Console.ReadLine();
        // user1 = new User(_username);
        fileAccess.LoadAll(user1);
        Console.WriteLine();
    }
    public int DisplayStartMenu()
    {
        Console.Write("Menu Options:\n  1. Start a workout\n  2. Create an exercise routine\n  3. Add a new exercise\n  4. Quit\nWhat would you like to do? ");

        if (int.TryParse(Console.ReadLine(), out int selector))
        {
            return selector;
        }
        else
        {
            Console.WriteLine("Not a valid input. Please try again.");
            return 0;
        }
        // try
        // {
        //     return int.Parse(Console.ReadLine());
        // }
        // catch
        // {
        //     Console.WriteLine("Not a valid input. Please try again.");
        //     continue;
        // }
    }
    public void DisplayLoadMenu()
    {}
    public void DisplaySaveMenu()
    {}
    public void DisplayExerciseMenu()
    {
        int selector = 0;

        while (selector != 1 && selector != 2)
        {
            Console.Write("\nExercise types:\n  1. Weighted exercise\n  2. Cardio exercise\nWhich type of exercise would you like to create? ");

            if (int.TryParse(Console.ReadLine(), out selector))
            {}
            else
            {
                Console.WriteLine("Not a valid input. Please try again.");
            }
        }


        Console.Write("What is the name of the exercise? ");
        string name = Console.ReadLine();
        Console.Write("Please type a brief of description of this exercise: ");
        string description = Console.ReadLine();
        Console.Write("Which muscle group is this exercise for? ");
        string muscleGroup = Console.ReadLine();

        switch (selector)
        {
            case 1:
                WeightedExercise w1 = new WeightedExercise(name, description, muscleGroup);
                user1.AddExercise(w1);
                fileAccess.SaveExercises(user1);
                user1.DisplayAllExercises();
                break;
            case 2:
                CardioExercise c1 = new CardioExercise(name, description, muscleGroup);
                user1.AddExercise(c1);
                fileAccess.SaveExercises(user1);
                user1.DisplayAllExercises();
                break;
            default:
            Console.WriteLine("Please try again.");
            break;
        }
    }
    public void DisplayRoutineMenu()
    {
        if (user1.HasNoExercises())
        {
            Console.WriteLine("You have not created any exercises yet. Please create one or more new exercises and then try again.");
            return;
        }

        Console.Write("What is the name of this routine? ");
        string name = Console.ReadLine();
        Console.Write("Please type a brief of description of this routine: ");
        string description = Console.ReadLine();

        Routine r1 = new Routine(name, description);
        user1.AddRoutine(r1);

        int selector = -1;
        while (selector != 0)
        {
            user1.DisplayAllExercises();
            Console.Write("Which number of exercise would you like to add? (Press 0 to quit.) ");

            if (int.TryParse(Console.ReadLine(), out selector))
            {}
            else
            {
                Console.WriteLine("Not a valid input. Please try again.");
            }

            if (selector == 0)
            {
                break;
            }

            user1.GetExerciseByIndex(selector).SetOtherInfo();
            r1.AddExerciseToRoutine(user1.GetExerciseByIndex(selector));

            Console.WriteLine();
            r1.DisplayRoutine();
            Console.WriteLine();
        }
        fileAccess.SaveRoutines(user1);
    }
    public void DisplayWorkoutMenu()
    {
        if (user1.HasNoRoutines())
        {
            Console.WriteLine("You have not created any workout routines yet. Please create a new routine and then try again.");
            return;
        }

        user1.DisplayAllRoutines();

        int selector = -1;
        while (selector != 0)
        {
            Console.Write("Which number of workout routine would you like to choose? (Press 0 to quit.) ");

            if (int.TryParse(Console.ReadLine(), out selector))
            {
                while (selector != 0)
                {
                    Routine selectedRoutine = user1.GetRoutineByIndex(selector);

                    selectedRoutine.DisplayRoutine();
                    Console.Write("Which exercise did you accomplish? ");
                    int num = int.Parse(Console.ReadLine());

                    if (num == 0)
                    {
                        break;
                    }

                    selectedRoutine.CompleteExerciseByIndex(num);

                    if (selectedRoutine.IsRoutineComplete() == true)
                    {
                        Console.WriteLine("You are now done with this routine!");
                        selector = 0;

                        // save the workout name and datetime of completion to file.
                        user1.AddCompletedExercise(selectedRoutine.GetRoutineName() + "," + DateTime.Now);
                        fileAccess.SaveUserWorkouts(user1, selectedRoutine.GetRoutineName(), DateTime.Now);
                        selectedRoutine.ResetRoutine();
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Not a valid input. Please try again.");
            }

            // if (selector == 0)
            // {
            //     break;
            // }
            // else
            // {
            //     int sel2 = -1;
            //     while (sel2 != 0)
            //     {
            //         selectedRoutine.DisplayRoutine();
            //         Console.Write("Which exercise did you accomplish? ");
            //         int num = int.Parse(Console.ReadLine());
            //         selectedRoutine.CompleteExerciseByIndex(num);
            //     }
            // }
        }

    }
    // public string GetName_Description_MuscleGroupFromUser()
    // {
    //     Console.Write("What is the name of the exercise?");
    //     string name = Console.ReadLine();
    //     Console.Write($"Please type a brief of description of the {name} exercise: ");
    //     string description = Console.ReadLine();

    //     return name, description;
    // }
}

// string filePath = AppDomain.CurrentDomain.BaseDirectory + @"resources\file.txt";
// if (File.Exists(filePath)) // import System.IO for this to work