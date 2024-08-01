class Wiki
{
    public string name = "John";
    public Wiki(string name)
    {
        this.name = name;
    }

    public void string hello()
    {
        Console.WriteLine($"Hello, Wiki {this.name}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Wiki wiki = new Wiki("Messi");
        wiki.hello();
    }

}