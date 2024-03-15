namespace variables;

class Program
{
    static void Main(string[] args)
    {
        string cat = "Lola";
        var date = DateTime.Now;
        Console.WriteLine($"Hello, {cat}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        float pi = 3.1415f;          // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String
        Console.WriteLine($"My integer number is {myNum}, my floating-point number is {myDoubleNum}, the value of pi is approximately {pi}, the letter I represent is {myLetter}, and my text is {myText}. My boolean is {myBool}.");
    }
}
