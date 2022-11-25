Console.WriteLine("METODO SETVALUE\n");

Random rand = new Random();

int[] vetor2 = new int[25];

for (int i = 1; i < vetor2.Length; i++)
{
    vetor2[i] = rand.Next(60);
    Console.WriteLine($"Foi atribuido o valor {i} à posição {vetor2[i]}");
}

Console.WriteLine("-----------------------------------------------------------");

vetor2.SetValue(13, 12);

Console.WriteLine($"Foi defino o valor 13 na posição 12: {vetor2[12]}");