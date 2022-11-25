Console.WriteLine("METODO COPY\n");

int[] vetor1 = new int[6];
int[] vetor2 = new int[6];
Random rand = new Random();

for (int i = 0; i < vetor1.Length; i++)
{
    vetor1[i] = rand.Next(60);
}

//public static void Copy(ArrayOrigem, ArrayDestino, QtdElementosCopiados);
int c = 0;
Array.Copy(vetor1, vetor2 , vetor1.Length);
foreach (int i in vetor1)
{
    Console.WriteLine($"Foi copiado o valor {i} da posição {c} do vetor1, para a posição {c} do vetor2: {vetor2[c]}");
    c++;    
}

