Console.WriteLine("Argumneto Params\n");

soma();

static void soma(params double[] n)
{
    if (n.Length < 1)
    {
        Console.WriteLine("Não foram inseridos valores a serem somados");
    }
    else if (n.Length < 2)
    {
        Console.WriteLine("Foi inserido apenas um valor: {0}", n[0]);
    }
    else
    {
        double som = 0;
        foreach (double d in n)
        {
            som += d;
        }
        Console.WriteLine("A soma dos valores é igual a {0}", som);
    }
}
