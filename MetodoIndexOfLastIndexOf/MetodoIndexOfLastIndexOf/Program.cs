Console.WriteLine("METODOS INDEXOF E LASTINDEXOF");

Random random = new Random();
int[] vetor1 = new int[50];

for (int i = 0; i < vetor1.Length; i++)
{
    vetor1[i] = random.Next(0,7);
    Console.WriteLine($"Na posição {i} foi atribuido o valor {vetor1[i]}");
}

int primeiroIndice = Array.IndexOf(vetor1, 3);
int ultimoIndice = Array.LastIndexOf(vetor1, 3);

Console.WriteLine($"\nO primeiro indice que conté o valor 3 é {primeiroIndice} e o ultimo é {ultimoIndice}");