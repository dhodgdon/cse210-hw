public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random rand = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = " reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        _questions = new List<string>() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    }
    public void Prompt()
    {
        int prompt = rand.Next(_prompts.Count);

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($" --- {_prompts[prompt]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.Clear();

        int rounds = 0;
        decimal dec = _duration % 15;

        if (dec == 0)
        {
            rounds = _duration / 15;
        }
        else if (dec >= 8)
        {
            rounds = (_duration + 15 - (Convert.ToInt32(Math.Round(dec)))) / 15;
        }
        else if (dec > 0 && dec < 8)
        {
            rounds = (_duration - Convert.ToInt32(Math.Round(dec))) / 15;
        }

        for (int i = 0; i < rounds; i++)
        {
            int question = rand.Next(_questions.Count);
            Console.Write($"> {_questions[question]} ");
            SpinnerPause(15);
            Console.WriteLine();
        }
    }
}