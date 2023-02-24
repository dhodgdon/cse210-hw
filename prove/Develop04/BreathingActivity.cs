public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = " relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing";
        _duration = 0;
    }
    public void Breathe()
    {
        int rounds;

        if (_duration < 5)
        {
            rounds = 1;
        }
        else
        {
            decimal convertToTenth = _duration / 10;
            rounds = Convert.ToInt32(Math.Round(convertToTenth));
        }

        Console.WriteLine("\nBreathe in as the circle expands... Breathe out as the circle contracts... ");
        SpinnerPause(3);

        for (int i = 0; i < rounds; i++)
        {
            BreathCircle();
        }
    }
    public void BreathCircle()
    {   
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("    *");
        Console.WriteLine("");
        Console.WriteLine("");

        Thread.Sleep(1000);
        Console.Clear();

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("   ***");
        Console.WriteLine("");
        Console.WriteLine("");

        Thread.Sleep(700);
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("    *");
        Console.WriteLine("   * *");
        Console.WriteLine("    *");
        Console.WriteLine("");

        Thread.Sleep(500);
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("   ***");
        Console.WriteLine("  *   *");
        Console.WriteLine("   ***");
        Console.WriteLine("");

        Thread.Sleep(400);
        Console.Clear();

        Console.WriteLine("    **");
        Console.WriteLine("   *  *");
        Console.WriteLine("  *    *");
        Console.WriteLine("   *  *");
        Console.WriteLine("    **");

        Thread.Sleep(900);
        Console.Clear();

        Console.WriteLine("    **");
        Console.WriteLine("  **  **");
        Console.WriteLine("**      **");
        Console.WriteLine("  **  **");
        Console.WriteLine("    **");

        Thread.Sleep(1500);
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("   ***");
        Console.WriteLine("  *   *");
        Console.WriteLine("   ***");
        Console.WriteLine("");

        Thread.Sleep(1500);
        Console.Clear();

        Console.WriteLine("");
        Console.WriteLine("    *");
        Console.WriteLine("   * *");
        Console.WriteLine("    *");
        Console.WriteLine("");

        Thread.Sleep(1500);
        Console.Clear();

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("   ***");
        Console.WriteLine("");
        Console.WriteLine("");

        Thread.Sleep(1500);
        Console.Clear();

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("    *");
        Console.WriteLine("");
        Console.WriteLine("");

        Thread.Sleep(500);
        Console.Clear();
    }
}