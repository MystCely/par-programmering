namespace ModelYourself;

public class ConsoleApp
{
    public void Run()
    {
        var input = new Input();

        string name = input.AskForName("What is your name? ");
        string hairCol = input.AskForHairCol("What is your hair color? ");
        string doingNow = input.AskForDoingNow("What are you doing right now?");
        int age = input.AskForAge("What is your age? ");
        
        Console.WriteLine($"Hi, my name is {name}. I'm {age} years old and I have {hairCol} hair.\n {doingNow} \n");
    }
}