class Program
{
    static void Main(string[] args)
    {
        int n1, n2, res;

        n1 = n2 = res = 0;

        Console.Write("Digite o 1º valor a ser dividido: ");
        n1 = Int32.Parse(Console.ReadLine());
        Console.Write("Digite o 2º valor: ");
        n2 = Int32.Parse(Console.ReadLine());

        try                             //O  PROGRAMA TENTARÁ EXECUTAR O TRY CASO NÃO CONSIGA IRÁ PARA CATCH
        {
            res = n1 / n2;
            Console.WriteLine($"{n1}/{2}={res}");
        }
        catch (Exception erro)           //ERRO RECEBE A EXCEÇÃO E PODE-SE PASSAR AO INVÉS DA CLASS Exception o erro direto como (DivideByZeroException erro)
        {
            //Console.WriteLine($"Erro: {erro.Message}");          //EXIBE NA SAIDA - ERRO: ATEMPTED TO DIVIDE BY ZERO
            //Console.WriteLine($"Erro: {erro}");                  //EXIBE NA SAIDA - ERRO: System.DivideByZeroException: Attempted to divide by zero.
            Console.WriteLine($"Erro: {erro.GetType()}");          //EXIBE NA SAIDA - ERRO: System.DivideByZeroException O METODO GETTYPE RETORNA O TIPO DA EXCEÇÃO
        }
    }
}