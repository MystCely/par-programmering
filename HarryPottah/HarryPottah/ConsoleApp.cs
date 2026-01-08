namespace HarryPottah;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        var name = input.AskForInput("What is your name?").Trim();

        string[] houses = ["Gryffindor", "Ravenclaw", "Hufflepuff", "Slytherin"];
        
        Console.WriteLine("\nHogwarts houses:");
        foreach (var house in houses)
        {
            Console.WriteLine(house);
        }
        
        var chosenHouse = input.AskForInput("\nPick a house.").Trim();
        var character = new Character(name, chosenHouse);
        
        // move PrintCharacterInfo further down in the code (with inventory)
        Console.WriteLine($"\nWelcome to Hogwarts, {character.Name} of {character.House}");
        character.PrintCharacterInfo();
        

        var storeItems = new List<StoreItem>()
        {
            new StoreItem("Owl"),
            new StoreItem("Rat"),
            new StoreItem("Cat"),
            new StoreItem("Phoenix Wand"),
            new StoreItem("Unicorn Wand"),
            new StoreItem("Troll Wand"),
        };

        Console.WriteLine("\nWelcome to the Magic Store");

        while (true)
        {
            Console.WriteLine("Available items:");
            foreach (var storeItem in storeItems)
            {
                storeItem.PrintStoreItems();
            }
            var chosenItem = input.AskForInput("\nPick an item.").Trim();
            character.Inventory.Add(chosenItem);
            
            // Change to continue until user chooses "exit"
            var answer = input.AskForInput("\nDo you want to buy another item? Answer with Yes/No").Trim().ToLower();
            if (answer == "yes")
            {
                continue;
            }
            if (answer == "no")
            {
                break;
            }

            Console.WriteLine("\nPlease chose a valid option");
        }

        // add a default gold value of 100 (or random value from 70-200)
        // add prices to items -> not able to buy items with less gold than the price 
        Console.Clear();
        Console.WriteLine($"{character.Name}'s Inventory:");
        foreach (var item in character.Inventory)
        {
            Console.WriteLine($"- {item}");
        }

        // add a method where user can only cast a spell if they have a wand in their inventory
        Console.WriteLine("\n Time to cast spell");
        Console.WriteLine("1. Boom\n2. Fly\n3. Zoom");
        var chosenSpell = input.AskForInput("What spell do u cast?").Trim().ToLower();
        if (chosenSpell == "boom") { Console.WriteLine("u explode something"); }
        if (chosenSpell == "fly") { Console.WriteLine("u fly"); }
        if (chosenSpell == "zoom") { Console.WriteLine("u go fast"); }
        

    }
    
}
