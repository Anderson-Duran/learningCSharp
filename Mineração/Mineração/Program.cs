//Console.WriteLine("Rig de MINERAÇÂO");


//double placas2 = 0.1146147;
//double placas3 = 0.1589382;
//double etc3 = 7.64898;


//inicio:

//Console.Write("\nDigite o valor ETH e ETC para saber a rentabilidade: R$ ");
//double valor = Convert.ToDouble(Console.ReadLine());
//double valorETC = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"\n2 placas para o valor de {valor.ToString("C")} = {(valor * placas2).ToString("C")}\n");
//Console.WriteLine($"\n3 placas para o valor de {valor.ToString("C")} = {(valor * placas3).ToString("C")}\n");
//Console.WriteLine("Valor para ETC\n");
//Console.WriteLine($"\n3 placas para o valor de ETC {valorETC.ToString("C")} = {(valorETC * etc3 * 5.48).ToString("C")}\n");

//char resp;

//Console.Write("Deseja continuar?[S/N]: ");
//resp = Convert.ToChar(Console.ReadLine());

//if (resp == 's')
//{
//    goto inicio;
//} 
//else
//{
//    Console.ReadKey();
//}

class aula26
{
    static void Main()
    {
        int num = 10;
        dobrar(num);
        Console.WriteLine(num);
        
    }

    static int dobrar(int valor)
    {
        valor *= 2;
        return valor;
    }
}
