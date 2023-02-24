public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _counter;
    private Random rand = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = " reflect on the good things in your life by having you list as many things as you can in a certain area";
        _counter = 0;
        _prompts = new List<string>() {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    }

    public void Prompt()
    {
        int prompt = rand.Next(_prompts.Count);
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[prompt]} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
    }
    public void Responses()
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

         while (endTime > DateTime.Now)
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter++;
        }
        
        Console.WriteLine($"You listed {_counter} items!");
    }
}