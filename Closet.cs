public class Closet
{
    // This team is the best : )
    // ABSOLUTLEY
    List<Clothing> _closet;
    
    public Closet()
    {
        _closet = new List<Clothing>();
    }

    public void DisplayItems()
    {
        foreach (Clothing clothing in _closet)
        {
            clothing.DisplayItem();
        }
    }

    public void DisplayAvailableItems()
    {
        foreach (Clothing clothing in _closet)
        {
            clothing.DisplayAvailable();
        }
    }

    public void AddItem(Clothing clothing)
    {
        _closet.Add(clothing);
    }

    public void RemoveItem()
    {
        Console.Write("What is the item's id? ");
        long _id = long.Parse(Console.ReadLine());
        _closet.Remove(FindById(_id));
    }

    public Clothing FindById(long id)
    {
         foreach (Clothing clothing in _closet)
        {
            if (clothing.GetId() = id)
            {
                return clothing;
            }
            else
            {
                console.WriteLine("Could not find ID");
            }
        }  
    }

    public List<Clothing> GetList()
    {
        return _closet;
    }
}