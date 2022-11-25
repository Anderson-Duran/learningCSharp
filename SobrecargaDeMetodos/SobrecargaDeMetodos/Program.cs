class Adicao
{

    //CRIAÇÃO DE DOIS METODOS COM RETORNO DE TIPOS DIFERENTES, ESSE É O CONCEITO DE SOBRECARGA DE METODOS

    public int Soma(params int[] n)
    {
        var result = 0;

        for (int i = 0; i < n.Length; i++)
        {
            result += n[i];
        }
        return result;
    }

    public double Soma(params double[] n)
    {
        double result = 0;

        for (int i = 0; i < n.Length; i++)
        {
            result += n[i];
        }
        return result;
    }
}

    //CLASSE PRINCIPAL 

class Program
{
    static void Main()
    {
        Adicao adicao = new Adicao();

        var resultado = adicao.Soma(1,9,78,1.15);       //NÃO OCORRE ERRO DE TIPO POIS VAR DO TIPO DOUBLE ACEITA VAR DO TIPO INT, FAZENDO SUA CONVERSÃO IMPLICITA

        Console.WriteLine($"A soma dos valores: {resultado}");

        
    }
}