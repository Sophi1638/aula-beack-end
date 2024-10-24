using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o lado A: ");
        int ladoA = int.Parse(Console.ReadLine());

        Console.Write("Informe o lado B: ");
        int ladoB = int.Parse(Console.ReadLine());

        Console.Write("Informe o lado C: ");
        int ladoC = int.Parse(Console.ReadLine());

        ClassificarTriangulo(ladoA, ladoB, ladoC);
    }

    static void ClassificarTriangulo(int ladoA, int ladoB, int ladoC)
    {
        if (ladoA == ladoB && ladoB == ladoC)
        {
            Console.WriteLine("Triângulo Equilátero.");
        }
        else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
        {
            Console.WriteLine("Triângulo Isósceles.");
        }
        else
        {
            Console.WriteLine("Triângulo Escaleno.");
        }
    }
}

