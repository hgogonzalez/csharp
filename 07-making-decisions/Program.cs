namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        int vida = 3;
        bool estaVivo = true;
        string nombreGato = "Lola";

        if (estaVivo)
        {
            vida++;
            Console.WriteLine($"{nombreGato} ha ganado una vida");
            Console.WriteLine($"La vida de {nombreGato} aumento a: {vida}");
        }
        else
        {
            vida--;
            Console.WriteLine($"{nombreGato}  ha perdido una vida");
            Console.WriteLine($"La vida de {nombreGato} disminuyó a: {vida}");
        }
    }
}
