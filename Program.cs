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
        
        animal = new Fox("Kurama");
        PrintAnimalVoice(animal);
        SaveAnimalVoice(animal);

        animal = new Fox();
        PrintAnimalVoice(animal);
        SaveAnimalVoice(animal);

        Cat cat = new Cat("Markiza");
        PrintAnimalVoice(cat);
        cat.VoiceCount++;
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
    public int VoiceCount { get; set; }

    private string _nickname;

    public AnimalBase(string nickname)
    {
        _nickname = nickname;
    }

    public virtual string GetVoice()
    {
        return "<silence>";
    }

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

public class Fox: AnimalBase
{
    public Fox(string nickname): base(nickname) {}

    public Fox(): base("Foxy") {}
}