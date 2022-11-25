Console.WriteLine("METODO SORT\n");

Random random = new Random();

int[] vetor1 = new int[10];
int[] vetor2 = new int[10];
int[] vetor3 = new int[10];

for (int i = 0; i < vetor1.Length; i++)
{
    vetor1[i] = random.Next(22);
    vetor2[i] = random.Next(22);
    vetor3[i] = random.Next(22);
}

Console.WriteLine("Forma desordenada\n");


foreach (int i in vetor1)
{
    Console.WriteLine($"vetor1 {i}");
}

Console.WriteLine("-----------------------------------------------");

foreach (int i in vetor2)
{
    Console.WriteLine($"vetor2 {i}");
}

Console.WriteLine("-----------------------------------------------");

foreach (int i in vetor3)
{
    Console.WriteLine($"vetor3 {i}");
}

Console.WriteLine("-----------------------------------------------\n");

Console.WriteLine("Após o metodo Sort\n");

Array.Sort(vetor1);
Array.Sort(vetor2);
Array.Sort(vetor3);

foreach (int i in vetor1)
{
    Console.WriteLine($"vetor1 {i}");   
}

Console.WriteLine("-----------------------------------------------");

foreach (int i in vetor2)
{
    Console.WriteLine($"vetor2 {i}");
}

Console.WriteLine("-----------------------------------------------");

foreach (int i in vetor3)
{
    Console.WriteLine($"vetor3 {i}");
}