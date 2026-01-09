namespace HarryPottah;

public class Character
{
    public string Name { get; }
    public string House { get; }
    public int Gold { get; set; }

    public List<StoreItem> Inventory { get; }

    public Character(string name, string house, int gold)
    {
        Name = name;
        House = house;
        Gold = gold;
        Inventory = new List<StoreItem>();
    }

    public void PrintCharacterInfo()
    {
        Console.WriteLine($"Name: {Name}, House: {House}");
    }
    
}