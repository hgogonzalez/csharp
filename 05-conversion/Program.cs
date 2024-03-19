namespace _05_conversion;

class Program
{
    static void Main(string[] args)
    {   
        // Explicit Conversion
        double numDecimal1 = 10.5;
        int numInt1 = (int)numDecimal1; 
        Console.WriteLine(numInt1);

        // Implicit Conversion
        int numInt2 = 10;
        double numDecimal2 = numInt2;
        Console.WriteLine(numDecimal2); 
    }
}
