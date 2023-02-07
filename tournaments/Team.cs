using System;

public class Team
{
    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }
    
    public void DisplayRoster()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine(_name);
        Console.WriteLine($"wins: {_wins}, losses: {_losses}");

        foreach (Player p in _roster)
        {
            Console.WriteLine();
            p.Display();
        }
        Console.WriteLine("-----------------------------");

    }

    public void AddWin()
    {
        _wins += 1;
    }
    public void AddLoss()
    {
        _losses += 1;
    }

    public string GetTeamName()
    {
        return _name;
    }
}