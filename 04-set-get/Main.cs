namespace HelloWorld;

class Program
{
     static void Main(string[] args)
    {
        User user1 = new User();
        user1.Name = "Binyamin Hoffman";
        user1.Country = "Argentina";
        Console.WriteLine($"{user1._name} is from {user1._country}.");

    }

}
