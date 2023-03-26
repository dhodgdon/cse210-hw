public class Menu
{
    private string _username;

    public Menu()
    {
        _username = "bob";
    }

    public void DisplayStartMenu()
    {
        Console.Write("Welcome to the Workout Program! Get ready to become large of stature!\n\nWhat is your username? ");
        _username = Console.ReadLine();

        Console.WriteLine("\nWhat would you like to do?\n  1. Start a workout\n  2. Access exercise routines\n  3. Add a new exercise");
    }
    public void DisplayLoadMenu()
    {}
    public void DisplaySaveMenu()
    {}
    public void DisplayExerciseMenu()
    {}
    public void DisplayRoutineMenu()
    {}
}