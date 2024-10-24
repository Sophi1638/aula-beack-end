using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe os gols do primeiro time: ");
        int golsPrimeiroTime = int.Parse(Console.ReadLine());

        Console.Write("Informe os gols do segundo time: ");
        int golsSegundoTime = int.Parse(Console.ReadLine());

        VerificarResultado(golsPrimeiroTime, golsSegundoTime);
    }

    static void VerificarResultado(int golsPrimeiroTime, int golsSegundoTime)
    {
        if (golsPrimeiroTime == golsSegundoTime)
        {
            Console.WriteLine("Empate.");
        }
        else if (golsPrimeiroTime > golsSegundoTime)
        {
            Console.WriteLine("Vitória do primeiro time.");
        }
        else
        {
            Console.WriteLine("Vitória do segundo time.");
        }
    }
}

