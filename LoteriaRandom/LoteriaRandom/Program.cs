using System;

class Gerar
{

    public void GeraJogo()
    {
        Random ran = new Random();
        List<int> lista = new List<int>();
        int num = 0;
        
        for (int j = 0; j < 6; j++)
        {
            num = ran.Next(1, 60);
            lista.Add(num);
        }
        lista.Sort();     
        
        for (int i = 0; i < lista.Count ;i++)
        {            
            if (i < lista.Count-1 )
            {
                Console.Write($"{lista[i]} - ");
            }
            else
            {
                Console.Write($"{lista[i]}.\n");
            }
            
        }
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerar jogo = new Gerar();

        
        Console.Write("Quantos jogos deseja fazer?: ");
        int nJogos = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < nJogos; i++)
        {
            Console.Write($"\nJogo {i+1}: ");
            jogo.GeraJogo();
        }
    }
}