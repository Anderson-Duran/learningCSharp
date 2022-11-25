//Console.Write("Quantidade de pessoas: ");
//int numeroPessoas = Convert.ToInt16(Console.ReadLine());

//Console.Write("Numero sanduiches: ");
//int numeroSanduiches = Convert.ToInt16(Console.ReadLine());

//int[] tamanhoPao = new int[numeroSanduiches];
//for (int i = 0; i < numeroSanduiches; i++)
//{
//    Console.Write("Tamanho dos sanduíches em cm: ");
//    tamanhoPao[i] = Convert.ToInt16(Console.ReadLine());
//}

//int tamCent = (int)((tamanhoPao.Max()) / numeroSanduiches);

//Console.WriteLine($"Tamanho máximo por fatia será {tamCent}cm");


int tam(int numeroPessoas, int numeroSanduiches, int[] tamanhoPao)
{
 
    int tamCent = (int)((tamanhoPao.Max()) / numeroSanduiches);

    Console.WriteLine($"Tamanho máximo por fatia será {tamCent}cm");
    return tamCent;
}

int x;
int y;


Console.Write("Quantidade de pessoas: ");
x = Convert.ToInt16(Console.ReadLine());

Console.Write("Numero sanduiches: ");
y = Convert.ToInt16(Console.ReadLine());

int[] z = new int[y];

for (int i = 0; i < y; i++)
{
    Console.Write("Tamanho dos sanduíches em cm: ");
    z[i] = Convert.ToInt16(Console.ReadLine());
}

tam(x, y, z);