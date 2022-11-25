using System.Globalization;

Console.WriteLine("TESTE WHILE!\n");

TextInfo texto = CultureInfo.CurrentCulture.TextInfo;

string[] name = new string[4];
int[] num = new int[4];
int i = 0;

while (i < num.Length - 1)
{

    Console.Write($"Digite o {i + 1}º nome: ");
    name[i] = Console.ReadLine();
    Console.Write($"Digite a {i + 1}º nota: ");
    num[i] = int.Parse(Console.ReadLine());
    i++;
}



i = 0;
while (i < num.Length - 1)
{
    Console.WriteLine($"\n{texto.ToTitleCase(name[i])} teve nota igual a {Convert.ToDouble(num[i])}.\n");
    i++;
}

char resposta = '0';



Console.ReadKey();
