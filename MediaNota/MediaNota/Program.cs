using MediaNota;

class Program
{
    static void Main()
    {
        Console.WriteLine("Média de Notas\n");

        Console.Write("Insira seu nome: ");
        string name = Console.ReadLine();

        inicio:
        Console.Clear();

        Console.WriteLine($"\nSeja bem vindo(a) {name}\nPara prosseguir insira as notas do aluno:\n");
        double media = InserçãoNotas.Nota();
      

        if (media >= 6 & media <= 10)
        {
            if (media >= 9)
            {
                Console.WriteLine("\nAluno aprovado com excêlencia\n");
            }
            else
            {
                Console.WriteLine("\nAluno aprovado\n");
            }
        }
        else if (media < 6 & media >= 4)
        {
            Console.WriteLine("\nAluno de recuperação\n");
        }
        else
        {
            Console.WriteLine("\nAluno reprovado!!!\n");
        }

        char resposta = '0';

        Console.Write("Há mais algum aluno para verificar? [s/n] ");
        resposta = Convert.ToChar(Console.ReadLine());

        if (resposta == 's' | resposta == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.WriteLine("\nObrigado! Fim do programa!");
        }
    }
}


