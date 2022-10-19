public class Program
{
    public static void Main()
    {
        PrintCatVoice(); 
        SaveCatVoice();
    }

    public static void PrintCatVoice()
    {
        Console.WriteLine("Meow");
    }

    public static void SaveCatVoice()
    {
        File.WriteAllText($"cat.voice", "Meow");
    }
}
