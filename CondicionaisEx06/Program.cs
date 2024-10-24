using System;

class Program
{
    static void Main()
    {
        int femininoSim = 0, femininoNao = 0, masculinoSim = 0, masculinoNao = 0;

        int quantidadePessoas = 0;
        int pessoas = int.Parse(Console.ReadLine("Informe a quantidade de pessoas: "));

        while (quantidadePessoas < pessoas)
        {
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

            quantidadePessoas++;
        }

        Console.WriteLine("Relatório:");
        Console.WriteLine($"Feminino - Sim: {femininoSim}");
        Console.WriteLine($"Feminino - Não: {femininoNao}");
        Console.WriteLine($"Masculino - Sim: {masculinoSim}");
        Console.WriteLine($"Masculino - Não: {masculinoNao}");
    }
}