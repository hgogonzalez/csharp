namespace _10_loops;

class Program
{
    static void Main(string[] args)
    {
        // for
        Console.WriteLine("---- for ----");
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(i);
        }
        
        // foreach
        Console.WriteLine("---- foreach ----");
        List<int> fibNumbers = [0, 1, 1, 2, 3, 5, 8, 13];
        foreach (int element in fibNumbers)
        {
            Console.WriteLine($"{element} ");
        }
        
        // while
        Console.WriteLine("---- while ----");
        int n = 0;
        while (n < 5)
        {
            Console.WriteLine(n);
            n++;
        }
        
        
        // await foreach
        // await foreach (var item in GetNumbersAsync())
        // {
        //   Console.WriteLine(item);
        // }
    }
    
    
}
