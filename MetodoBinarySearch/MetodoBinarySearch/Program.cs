Console.WriteLine("METODO BINARYSEARCH\n");

//ESTE MÉTODO RETORNA A POSIÇÃO DO VALOR INTEIRO PROCURADO


int tentativa = 0;

inicio:
Console.Clear();

int[] vetor1 = new int[5];
int[] vetor2 = new int[5];
int[] vetor3 = new int[5];
int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66,77,88,99,00} };

Random random = new Random();

for (int i = 0; i < vetor1.Length; i++)
{
    vetor1[i] = random.Next(50);
    Console.WriteLine($"Na posição {i} foi atribuido o valor {vetor1[i]}");
}


//public static int BinarySearch(vetor/array, valor procurado);

int numberSerached = 33;
int index = Array.BinarySearch(vetor1, numberSerached);


if (index < 0)
{
    while (index < 0)
    {
        Console.WriteLine($"\nNão foi encontrado o valor {numberSerached}");
        tentativa++;
        goto inicio;

    }

}
else
{
    if (tentativa < 0)
    {
        tentativa = 1;
    }
    Console.WriteLine($"\nNa posição {index} foi encotrado o valor {numberSerached}.\nFoi(ram) realizada(s) {tentativa} tentativa(s). ");
}


