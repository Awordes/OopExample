public class Program
{
    public static void Main()
    {
        var cat = new Cat();
        PrintAnimalVoice(cat);
        SaveAnimalVoice(cat);

        var dog = new Dog();
        PrintAnimalVoice(dog);
        SaveAnimalVoice(dog);
    }

    public static void PrintAnimalVoice(AnimalBase animal)
    {
        Console.WriteLine(animal.GetVoice());
    }

    public static void SaveAnimalVoice(AnimalBase animal)
    {
        File.WriteAllText($"animal.voice", animal.GetVoice());
    }
}

public abstract class AnimalBase
{
    public abstract string GetVoice();
}

public class Cat: AnimalBase
{
    public override string GetVoice()
    {
        return "Meow";
    }
}

public class Dog: AnimalBase
{
    public override string GetVoice()
    {
        return "Woof";
    }
}