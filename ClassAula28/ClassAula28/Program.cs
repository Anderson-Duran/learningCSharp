using System;
using ClassAula28;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Primeira Classe");

        char ans;
        int qt;
        int counter = 0;

        Console.Write("Deseja adicionar cliente? [S/N]: ");
        ans = Convert.ToChar(Console.ReadLine());
        Console.Write("Quantos: ");
        qt = Convert.ToInt16(Console.ReadLine());

        if (ans == 's' | ans == 'S')
        {
         
            for (int i = 0; i < qt; i++)
            {
                Cliente[] cliente = new Cliente[qt];
                cliente[i] = new Cliente();
                

                Console.Write("Insira o nome: ");
                cliente[i].name = Console.ReadLine();
                Console.Write("Insira o endereço: ");
                cliente[i].adress = Console.ReadLine();
                Console.Write("Insira a idade: ");
                cliente[i].age = Convert.ToInt16(Console.ReadLine());
                
                
                Console.WriteLine($"Cliente: {cliente[i].name} criado com sucesso!");
            }
            
        }
        else
        {
            Console.WriteLine("Obrigado!");
        }

        

    }
}
