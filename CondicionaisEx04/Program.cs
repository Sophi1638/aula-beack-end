using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe sua senha: ");
        string senha = Console.ReadLine();

        VerificarSenha(senha);
    }

    static void VerificarSenha(string senha)
    {
        string senhaValida = "1234";

        if (senha == senhaValida)
        {
            Console.WriteLine("ACESSO PERMITIDO");
        }
        else
        {
            Console.WriteLine("ACESSO NEGADO");
        }
    }
}

