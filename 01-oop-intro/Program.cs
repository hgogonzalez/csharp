namespace _01_oop_intro;

class Program
{
    static void Main(string[] args)
    {
        Cat myCat = new Cat("Vittorio", "Italy");
        myCat.Meow();
        myCat.DisplayLocation();
    }
}
