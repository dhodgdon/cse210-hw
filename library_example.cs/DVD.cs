public class DVD : Loanable
{
    private string _title;
    private int _length;
    private int _upc;

    public DVD(string title, int length, int upc)
    {
        _title = title;
        _length = length;
        _upc = upc;
    }
    
    public virtual void ShowDVDDetails()
    {
        Console.WriteLine($"{_title}: {_length} minutes, {_upc}");
    }
}