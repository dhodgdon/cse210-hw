public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "";
        _duration = 50;
    }
    public Activity(int duration)
    {
        _name = "Activity";
        _description = "";
        _duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will help you{_description}.\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        SpinnerPause(3);
    }
    public void EndMessage()
    {
        Console.WriteLine("\nWell done!");
        SpinnerPause(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        SpinnerPause(3);
    }
    protected void SpinnerPause(int rounds)
    {
        for (int i = 0; i < rounds; i++)
        {
            Console.Write("-");
            Thread.Sleep(150);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(50);
            Console.Write("\b \b");
        }
    }
    public void Countdown(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

}