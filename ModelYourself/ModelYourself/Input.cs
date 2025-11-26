namespace ModelYourself;

public class Input
{
    public string AskForName(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
    
    public string AskForHairCol(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
    
    public string AskForDoingNow(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return input;
    }
    
    public int AskForAge(string question)
    {
        Console.WriteLine(question);
        var input = Console.ReadLine();
        return int.Parse(input);
    }
}