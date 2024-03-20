namespace HelloWorld;

class Program
{
    static string username;
    static string password;
    
    static void Main(string[] args)
    {
        Register();
        Login();
    }
    
    public static void Register()
    {
       Console.WriteLine("Please enter you're username");
       username = Console.ReadLine();
       Console.WriteLine("Please enter you're password");
       password = Console.ReadLine();
       
       Console.WriteLine("Registration completed");
       Console.WriteLine("----------------------------------------");
    }
    
    public static void Login()
    {
        Console.WriteLine("Please enter you're username");
        if (username == Console.ReadLine())
        {
            Console.WriteLine("Please enter you're password");
            if (password == Console.ReadLine())
            {
                Console.WriteLine("Login successful");
            } else
            {
                Console.WriteLine("Login failed, wrong password. Restart Program");
                Console.WriteLine("----------------------------------------");
            }
        } else
        {
            Console.WriteLine("Login failed, wrong password. Restart Program");
           
        }

        
    }
}
