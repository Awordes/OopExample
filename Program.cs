public class Program
{
    public static void Main()
    {
        var cat = new Cat();
        PrintCatVoice(cat); 
        SaveCatVoice(cat);
    }

    public static void PrintCatVoice(Cat cat)
    {
        Console.WriteLine(cat.GetVoice());
    }

    public static void SaveCatVoice(Cat cat)
    {
        File.WriteAllText($"cat.voice", cat.GetVoice());
    }
}

public class Cat
{
    public string GetVoice()
    {
        return "Meow";
    }
}