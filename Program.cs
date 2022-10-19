public class Program
{
    public static void Main()
    {
        var cat = new Cat();
        PrintCatVoice(cat); 
        SaveCatVoice(cat);

        var dog = new Dog();
        PrintDogVoice(dog);
        SaveDogVoice(dog);
    }

    public static void PrintCatVoice(Cat cat)
    {
        Console.WriteLine(cat.GetVoice());
    }

    public static void SaveCatVoice(Cat cat)
    {
        File.WriteAllText($"cat.voice", cat.GetVoice());
    }

    public static void PrintDogVoice(Dog dog)
    {
        Console.WriteLine(dog.GetVoice());
    }

    public static void SaveDogVoice(Dog dog)
    {
        File.WriteAllText($"dog.voice", dog.GetVoice());
    }
}

public class Cat
{
    public string GetVoice()
    {
        return "Meow";
    }
}

public class Dog
{
    public string GetVoice()
    {
        return "Woof";
    }
}