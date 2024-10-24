using System;

class Program
{
    static void Main()
    {
        float precoProduto = 200;
        float minhacarteira = 350;

        bool podeComprar = PodeComprarProduto(precoProduto, minhacarteira);

        if (podeComprar)
        {
            Console.WriteLine("Sim voce pode comprar.Boa rica");
        }
        else
        {
            Console.WriteLine("Nao voce nao pode comprar o produto.Ta duro dorme");
        }
    }

    static bool PodeComprarProduto(float precoProduto, float carteira)
    {
        return carteira >= precoProduto;
    }
}
