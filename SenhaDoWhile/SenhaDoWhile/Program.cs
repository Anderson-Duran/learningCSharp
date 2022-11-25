using System;
using System.Globalization;



class Program
{
    public static void Main()
    {
        TextInfo texto = CultureInfo.CurrentCulture.TextInfo;

        Console.Write("Insira o seu nome: ");
        string name = texto.ToTitleCase(Console.ReadLine());

        Console.WriteLine($"\nOlá {name} tudo bem?!\nFaça seu login para acessar o conteúdo\n");

        string senha = "15051988";
        string userPassword;

        do
        {
            Console.Write($"\nDigite sua senha: ");
            userPassword = Console.ReadLine();
            if (senha != userPassword)
            {
                Console.Clear();
                Console.WriteLine($"Senha inválida {name}");
            }
            else
            {
                Console.Clear();
            }
        }
        while (userPassword != senha);


        Console.WriteLine($"Senha inserida com sucesso!\n\nSeja bem vindo(a) {name}");

        Console.ReadKey();
    }
}