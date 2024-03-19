namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        int vida = 3;
        bool estaVivo = false;

        if (!estaVivo)
        {
            vida++;
            Console.WriteLine("El gato ha ganado una vida");
            Console.WriteLine($"La vida del gato aumento a: {vida}");
        }
        else
        {
            vida--;
            Console.WriteLine("El gato ha perdido una vida");
            Console.WriteLine($"La vida del gato disminuyó a: {vida}");
        }
    }
}
