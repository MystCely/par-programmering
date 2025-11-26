namespace ModelYourself;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        string name = input.AskForDetails("What is your name? ");
        string hairCol = input.AskForDetails("What is your hair color? ");
        string doingNow = input.AskForDetails("What are you doing right now?");
        string doingTonight = input.AskForDetails("What will you do tonight?");
        int age = Convert.ToInt32(input.AskForDetails("What is your age? "));
        
        Console.WriteLine($"Hi, my name is {name}. I'm {age} years old and I have {hairCol} hair.\n{doingNow} \n{doingTonight}");
    }
}