using System;

class Program
{
    static void Main()
    {
        int femininoSim = 0, femininoNao = 0, masculinoSim = 0, masculinoNao = 0;

        Console.Write("Informe a quantidade de pessoas: ");
        int pessoas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= pessoas; i++)
        {
            Console.WriteLine($"\nPessoa {i}:");
            Console.Write("Informe o sexo (F - Feminino / M - Masculino): ");
            char sexo = char.Parse(Console.ReadLine());

            Console.Write("Gosta de esportes? (S - Sim / N - Não): ");
            char esportes = char.Parse(Console.ReadLine());

            if (sexo == 'F' || sexo == 'f')
            {
                if (esportes == 'S' || esportes == 's')
                {
                    femininoSim++;
                }
                else
                {
                    femininoNao++;
                }
            }
            else if (sexo == 'M' || sexo == 'm')
            {
                if (esportes == 'S' || esportes == 's')
                {
                    masculinoSim++;
                }
                else
                {
                    masculinoNao++;
                }
            }
        }

        Console.WriteLine("\nRelatório:");
        Console.WriteLine($"Feminino - Sim: {femininoSim}");
        Console.WriteLine($"Feminino - Não: {femininoNao}");
        Console.WriteLine($"Masculino - Sim: {masculinoSim}");
        Console.WriteLine($"Masculino - Não: {masculinoNao}");
    }
}
