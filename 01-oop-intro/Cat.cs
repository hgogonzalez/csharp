public class Cat {
    // Properties
    public string Name { get; set; }
    public string Country { get; set; }

    // Constructor
    public Cat(string name, string country) {
        Name = name;
        Country = country;
    }
       
    // Method
    public void Meow() {
        Console.WriteLine($"{Name} says: Meow!");
    }
    
    // Method
    public void DisplayLocation() {
        Console.WriteLine($"{Name} live in {Country}");
    }
}
