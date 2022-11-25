Console.WriteLine("METODO COPYTO\n");

Random random = new Random();   

int[] vetor1 = new int[8];
int[] vetor3 = new int[8];
for (int i = 0; i < vetor1.Length; i++)
{
    vetor1[i] = random.Next(100);
    Console.WriteLine($"Foi atribuido o valor {vetor1[i]} a posição {i} do vetor1");
}

Console.WriteLine("--------------------------------------------------------------------");


//public void CopyTo(ArrayDestino, APartirDestaPosição);

vetor1.CopyTo(vetor3, 0);

int c = 0;
foreach (int i in vetor3)
{
    Console.WriteLine($"Valor de vetor3 posição {c}: {i}");
    c++;    
}
