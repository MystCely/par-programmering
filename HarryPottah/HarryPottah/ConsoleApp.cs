namespace HarryPottah;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();
        
        var name = input.AskForInput("What is your name?").Trim();
        
        string[] houses = ["Gryffindor", "Ravenclaw", "Hufflepuff", "Slytherin"];
        string houseChoice;
        while (true)
        {
            houseChoice = input.AskForInput($"\n{name}, pick a house: Gryffindor, Ravenclaw, Hufflepuff, Slytherin").Trim();
            
            if(houses.Any(h => h.Equals(houseChoice,StringComparison.OrdinalIgnoreCase)))
                break;
            
            Console.WriteLine("Invalid House. Try again.");
        }
        
        var character = new Character(name, houseChoice, 200);
        Console.WriteLine($"\nWelcome to Hogwarts, {character.Name} of {character.House}");
        
        var storeItems = new List<StoreItem>()
        {
            new StoreItem("Owl", 100),
            new StoreItem("Rat", 30),
            new StoreItem("Cat", 60),
            new StoreItem("Phoenix Wand", 120),
            new StoreItem("Unicorn Wand", 100),
            new StoreItem("Troll Wand", 70),
        };

        MagicStore magicStore = new MagicStore(storeItems);
        while (true)
        {
            Console.WriteLine("\nMagic Store");
            Console.WriteLine($"Available gold: {character.Gold}");
            Console.WriteLine("\nAvailable items:");
            foreach (var storeItem in storeItems)
            {
                storeItem.PrintStoreItems();
            }
            

            var answer = input.AskForInput("\nPick an item. Type exit to continue").Trim();
            if (answer.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;
            
            if (answer == "Owl") { character.Gold -= 100; }
            if (answer == "Rat") { character.Gold -= 30; }
            if (answer == "Cat") { character.Gold -= 60; }
            if (answer == "Phoenix Wand") { character.Gold -= 120; }
            if (answer == "Unicorn Wand") { character.Gold -= 100; }
            if (answer == "Troll Wand") { character.Gold -= 70; }

            var selectedItem = magicStore.GetItemByName(answer);

            if (selectedItem == null)
            {
                Console.WriteLine("That item does not exist.");
                continue;
            }

            character.Inventory.Add(selectedItem);
            Console.WriteLine($"You bought {selectedItem.Name}");
        }
        
        Console.Clear();
        Console.WriteLine($"{character.Name}'s Inventory:");
        foreach (var item in character.Inventory)
        {
            Console.WriteLine($"- {item.Name}");
        }
        
        character.PrintCharacterInfo();

        // add a method where user can only cast a spell if they have a wand in their inventory
        bool hasWand = character.Inventory.Any(item =>
            item.Name == "Phoenix Wand" ||
            item.Name == "Unicorn Wand" ||
            item.Name == "Troll Wand"
        );

        if (hasWand)
        {
            Console.WriteLine("\nTime to cast spell");
            Console.WriteLine("1. Boom\n2. Fly\n3. Zoom");

            var chosenSpell = input.AskForInput("What spell do u cast?")
                .Trim()
                .ToLower();

            if (chosenSpell == "boom") Console.WriteLine("u explode something");
            if (chosenSpell == "fly") Console.WriteLine("u fly");
            if (chosenSpell == "zoom") Console.WriteLine("u go fast");
        }
        else
        {
            Console.WriteLine("You didn't purchase a wand as a magician, you fail.");
        }

        

    }
    
}
