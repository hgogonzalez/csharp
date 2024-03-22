public class Person
{
    // Properties
    public string Name { get; set; }
    public string Country { get; set; }

    // Constructor
    public Person(string name, string country)
    {
        Name = name;
        Country = country;
    }

    public Person()
    {
        Name = "Binyamin Hoffmann";
        Country = "Deutschland";
    }

    // Method
    public void Hello()
    {
        Console.WriteLine($"Hello, I'm {Name} from {Country}");
    }

    // Method
    public void DisplayLocation()
    {
        Console.WriteLine($"{Name} live in {Country}");
    }
}
