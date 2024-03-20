namespace _09_switch_statement;

class Program
{
    static void Main(string[] args)
    {
        int option = 2;

        switch (option)
        {
            case 1:
                Console.WriteLine("Option 1 selected");
                break;
            case 2:
                Console.WriteLine("Option 2 selected");
                break;
            case 3:
                Console.WriteLine("Option 3 selected");
                break;
            default:
                Console.WriteLine("Option not recognized");
                break;
        }
    }
}
