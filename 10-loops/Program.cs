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
        
        // Example of using break statement
        Console.WriteLine("Example of using break statement:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Breaking out of loop at i = 3");
                break; // Break out of the loop when i is 3
            }
            Console.WriteLine($"Current value of i: {i}");
        }

        Console.WriteLine(); // Empty line for spacing

        // Example of using continue statement
        Console.WriteLine("Example of using continue statement:");
        for (int j = 1; j <= 5; j++)
        {
            if (j == 3)
            {
                Console.WriteLine("Skipping iteration at j = 3");
                continue; // Skip the current iteration when j is 3
            }
            Console.WriteLine($"Current value of j: {j}");
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
