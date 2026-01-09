namespace HarryPottah;

public class StoreItem
{
    public string Name { get; }
    public int Price { get; }

    public StoreItem(string name, int price)
    {
        Name = name;
        Price = price;
    }
    
    public void PrintStoreItems()
    {
        Console.WriteLine($"- {Name}: {Price}");
    }
}