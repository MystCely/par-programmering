namespace ModelYourself;

public class Input
{
    public string AskForDetails(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
}