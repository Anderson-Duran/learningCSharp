delegate int Op(params int[] n);

class Mat
{
    public static int Soma(params int[] n)
    {
        int result = 0;

        for (int i = 0; i < n.Length; i++)
        {
            result += n[i];
        }
        return result;
    }

    public static int Mult(params int[] n)
    {
        int result= 1;

        for (int i = 0; i < n.Length; i++)
        {
            result *= n[i];
        }
        return result;
    }
}

class Program
{
    static void Main()
    {
        Op Adicao = new Op(Mat.Soma);       //ATRIBUI O METODO SOMA À VAR ADICAO

        int n1, n2;

        n1 = 20;
        n2 = 250;

        Console.WriteLine($"A soma entre os valores {n1} e {n2} = {Adicao(n1,n2)}");

        Adicao = new Op(Mat.Mult);          //ATRIBUI O METODO MULT À VAR ADICAO

        Console.WriteLine($"A multiplicação entre {n1} e {n2} = {Adicao(n1,n2)}");

    }
}