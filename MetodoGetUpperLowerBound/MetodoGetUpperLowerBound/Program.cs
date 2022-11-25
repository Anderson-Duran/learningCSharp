Console.WriteLine("METODO GETLOWERBOUND E GETUPPERBOUND\n");

int[] vetor1 = new int[6];
int[,] matriz = new int[4, 4] { {1,3,4,5 }, {8,9,7,6 }, {12,13,15,19 }, {29,30,24,25 } };

Random random = new Random();   

for (int x = 0; x < vetor1.Length; x++)
{
    vetor1[x] = random.Next(180);
    Console.WriteLine($"Na posição {x} do vetor1. foi atribuido o valor: {vetor1[x]}");
}

Console.WriteLine("-----------------------------------------------------------------");

//public int GetLowerBound/GetUpperBound(dimensão);

int MaiorIndiceVetor = vetor1.GetUpperBound(0);
int MenorIndiceVetor = vetor1.GetLowerBound(0);
int MaiorIndiceMatriz = matriz.GetUpperBound(1);
int MenorIndiceMatriz = matriz.GetLowerBound(1);

Console.WriteLine($"Maiores indices array e matriz respectivamente {MaiorIndiceVetor} e {MaiorIndiceMatriz}\n");
Console.WriteLine($"Menores indices array e matriz respectivamente {MenorIndiceVetor} e {MenorIndiceMatriz}\n");
Console.WriteLine($"O numero de dimensões da matriz é igual a {matriz.Rank} dimensões\n");

// verifica quantidade de dimensões da matriz
int rank = matriz.Rank;
Console.WriteLine($"Number of dimensions: {rank}");
for (int ctr = 0; ctr < rank; ctr++)
    Console.WriteLine($"   Dimension {ctr}: " +
                      $"from {matriz.GetLowerBound(ctr)} to {matriz.GetUpperBound(ctr)}");

