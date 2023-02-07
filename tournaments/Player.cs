public class Player
{
    private string _name;
    private int _jersey;

    public Player(string name, int jersey)
    {
        _name = name;
        _jersey = jersey;
    }

    public void Display()
    {
        Console.WriteLine($"{_name}: {_jersey}");
    }
}