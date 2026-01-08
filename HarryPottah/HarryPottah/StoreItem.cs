namespace HarryPottah;

public class StoreItem
{
    public string Name { get; set; }

    public StoreItem(string name)
    {
        Name = name;
    }
    
    public void PrintStoreItems()
    {
        Console.WriteLine($"- {Name}");
    }
}