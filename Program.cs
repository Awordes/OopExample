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

    public static void PrintAnimalVoice(IAnimal animal)
    {
        Console.WriteLine(animal.GetVoice());
    }

    public static void SaveAnimalVoice(IAnimal animal)
    {
        File.WriteAllText($"animal.voice", animal.GetVoice());
    }
}

public interface IAnimal
{
    string GetVoice();
}

public class Cat: IAnimal
{
    public string GetVoice()
    {
        return "Meow";
    }
}

public class Dog: IAnimal
{
    public string GetVoice()
    {
        return "Woof";
    }
}