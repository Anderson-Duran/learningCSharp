//CONCEITO DE RECURSIVIDADE É A FUNÇÃO CHAMANDO ELA MESMA


class Operacao
{
    public int Fatorial(int n)
    {
        int result;
        
        //SE A RECURSIVIDADE FOR PASSADA SEM PARAMETRO DE PARADA ENTR EM LOOP INFINITO, DESSA FORMA

        //result = n * Fatorial(n-1);          
        
        //DEVE-SE PASSAR UM CONTROLE DE PARADA
        
        if (n <= 1)
        {
            result = 1;
        }
        else
        {
            result = n*Fatorial(n-1);
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        inicio:

        Operacao operacao = new Operacao();

        int n;

        Console.Write($"Digite um número para saber seu fatorial: ");
        n = Convert.ToInt32(Console.ReadLine());

        int result = operacao.Fatorial(n);

        Console.WriteLine($"O Fatorial de {n} = {result}");

        string resp;

        Console.Write($"Deseja algums outro número?[S/N] ");
        resp = Console.ReadLine().ToUpper();

        if (resp == "S")
        {
            Console.Clear();
            goto inicio;
        }
        else
        {
            Console.WriteLine("\nObrigado por usar nosso programa!");
        }
    }
}