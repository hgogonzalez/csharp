namespace _04_strings;

class Program
{
    static void Main(string[] args)
    {
        string catName = "Lola";
        string greet = "Hello";
        Console.WriteLine($"{greet.ToLower()} {catName.ToUpper()}");

        string cat = "Lola";
        var date = DateTime.Now;
        Console.WriteLine($"Hello, {cat}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        string str = "Hello World from C#";
        string[] arr = str.Split(' ');
        Console.WriteLine("[{0}]", string.Join(", ", arr));
    }
}
