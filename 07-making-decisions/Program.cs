namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        bool isAdmin = false;
        bool isRegistered = true;
        string userName = "tartaruga";

        if (isRegistered && userName != "" && userName.Equals("Admin"))
        {
            Console.WriteLine($"Hi everyone, registered user");
            Console.WriteLine($"Hi there, {userName}");
            Console.WriteLine($"Hi there, Admin");

        }

        if (isAdmin || isRegistered)
        {
            Console.WriteLine($"{userName} you're logged in");
        }
    }
}


