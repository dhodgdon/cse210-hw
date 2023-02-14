public class Magazine : Loanable
{
    private string _title;
    private string _edition;
    private int _upc;

    public Magazine(string title, string edition, int upc)
    {
        _title = title;
        _edition = edition;
        _upc = upc;
    }
    
    public void ShowMagazineDetails()
    {
        Console.WriteLine($"{_title}: {_edition} edition, {_upc}");
    }
}