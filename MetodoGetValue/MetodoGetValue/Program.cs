Console.WriteLine("METODO GETVALUE");


int[] vetor1 = new int[6];
int[,] matriz = new int[4, 4] { { 1, 3, 4, 5 }, { 8, 9, 7, 6 }, { 12, 13, 15, 19 }, { 29, 30, 24, 25 } };

Random random = new Random();

for (int x = 0; x < vetor1.Length; x++)
{
    vetor1[x] = random.Next(180);
    Console.WriteLine($"Na posição {x} do vetor1. foi atribuido o valor: {vetor1[x]}");
}

Console.WriteLine("-----------------------------------------------------------------");

//public object GetValue(long indice);

int valor0 = (int)vetor1.GetValue(3);
int valor1 = (int)matriz.GetValue(2,1);

Console.WriteLine($"Valor indice 3 do vetor1: {valor0}");
Console.WriteLine($"Valor indice 2,1 da matriz: {valor1}");
