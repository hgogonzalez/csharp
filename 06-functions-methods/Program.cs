namespace HelloWorld;

using MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        string message = Hello();
        Console.WriteLine(message);

        Add addInstance = new Add(); 
        int result = addInstance.Sum(5, 3);
        Console.WriteLine($"Result: {result}");

        WriteSomethind();
    }

    static string Hello()
    {
        return "Hello, World!";
    }

    public static void WriteSomethind()
    {
        Console.WriteLine("I'm called from a method");
    }
}
