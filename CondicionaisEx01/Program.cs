//  Faça um programa que o usuario informe o salario recebido e o total dos gatos. Devera ser exibino na tela "Gastos dentro do orsamento" caso o valor dos gastos nao utrapassar  o valor do salario  e "Orçamento estourado" se o valor dos gastos ultrapassar o valor do salario.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe seu salário: R$ ");
        float salario = float.Parse(Console.ReadLine());

        Console.Write("Informe o total dos gastos: R$ ");
        float gastos = float.Parse(Console.ReadLine());

        VerificarOrçamento(salario, gastos);
    }

    static void VerificarOrçamento(float salario, float gastos)
    {
        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento.");
        }
        else
        {
            Console.WriteLine("Orçamento estourado.");
            Console.WriteLine($"Você está R$ {gastos - salario} acima do orçamento.");
        }
    }
}
