namespace variables;

class Program
{
    static void Main(string[] args)
    {
        string cat = "Lola";
        var date = DateTime.Now;
        Console.WriteLine($"Hello, {cat}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        string country = "Argentina";
        Console.WriteLine($"I born in {country} in 1985");
    }
}
