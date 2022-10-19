public class Program
{
    public static void Main()
    {
        AnimalBase animal = new Cat("Myrzik");
        PrintAnimalVoice(animal);
        SaveAnimalVoice(animal);

        animal = new Dog("Dryzhok");
        PrintAnimalVoice(animal);
        SaveAnimalVoice(animal);
    }

    public static void PrintAnimalVoice(AnimalBase animal)
    {
        Console.WriteLine(animal.GetVoice());
    }

    public static void SaveAnimalVoice(AnimalBase animal)
    {
        File.WriteAllText($"{animal.GetNickname()}.voice", animal.GetVoice());
    }
}

public abstract class AnimalBase
{
    private string _nickname;

    public AnimalBase(string nickname)
    {
        _nickname = nickname;
    }

    public abstract string GetVoice();

    public string GetNickname()
    {
        return _nickname;
    }
}

public class Cat: AnimalBase
{
    public Cat(string nickname): base(nickname) { }

    public override string GetVoice()
    {
        return "Meow";
    }
}

public class Dog: AnimalBase
{
    public Dog(string nickname): base(nickname) { }

    public override string GetVoice()
    {
        return "Woof";
    }
}