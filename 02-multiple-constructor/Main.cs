namespace _01_oop_intro;

class Program
{
    static void Main(string[] args)
    {
        Person vittorio = new Person("Vittorio Bianchi", "Italy");
        vittorio.Hello();
        vittorio.DisplayLocation();

        Person leah = new Person("Leah Goldman", "Polska");
        leah.Hello();
        leah.DisplayLocation();

        Person lewi = new Person("Lewi Lewandowski", "Polska");
        lewi.Hello();
        lewi.DisplayLocation();

        Person binyamin = new Person();
        binyamin.Hello();
        binyamin.DisplayLocation();
    }
}
