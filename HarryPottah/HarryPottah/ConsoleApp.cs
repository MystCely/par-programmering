namespace HarryPottah;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        var name = input.AskForInput("What is your name?").Trim();

        string[] houses = ["Gryffindor", "Ravenclaw", "Hufflepuff", "Slytherin"];
        
        foreach (var house in houses)
        {
            Console.WriteLine(house);
        }

        var chosenHouse = input.AskForInput("Pick a house.").Trim();
        var character = new Character(name, chosenHouse);
        
        character.PrintCharacterInfo();
        
        Console.WriteLine($"Welcome to Hogwarts, {name} of {chosenHouse}");

        var storeItems = new List<StoreItem>()
        {
            new StoreItem("Owl"),
            new StoreItem("Rat"),
            new StoreItem("Cat"),
            new StoreItem("Phoenix Wand"),
            new StoreItem("Unicorn Wand"),
            new StoreItem("Troll Wand"),
        };

        foreach (var storeItem in storeItems)
        {
            storeItem.PrintStoreItems();
        }
    }
}