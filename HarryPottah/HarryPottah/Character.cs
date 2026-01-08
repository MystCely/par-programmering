namespace HarryPottah;

public class Character
{
    public string Name { get; set; }
    public string House { get; set; }

    public List<string> Inventory = new List<string>();

    public Character(string name, string house)
    {
        Name = name;
        House = house;
        // Inventory = inventory;
    }

    public void PrintCharacterInfo()
    {
        Console.WriteLine($"Name: {Name}, House: {House}");
    }
    
}