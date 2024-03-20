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

        if (vida >=3) {
            vida += 5;
            Console.WriteLine($"{nombreGato} se ha transformando en SuperCat");
            Console.WriteLine($"La vida de {nombreGato} aumento a: {vida}");
            Console.WriteLine($"{nombreGato} tiene {vida} vidas");
        } else {
            Console.WriteLine($"{nombreGato} aun no puede transformarse en SuperCat");
        }

        TryParse tryParse = new TryParse();
        tryParse.Main();
    }
}

public class TryParse
{
    public void Main()
    {
        string[] values = { null, "160519", "9432.0", "16,667", "   -322   ", "+4302", "(100);", "01FA" };
        foreach (var value in values)
        {
            int number;

            bool success = int.TryParse(value, out number);
            if (success)
            {
                Console.WriteLine($"Converted '{value}' to {number}.");
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
            }
        }
    }
}
