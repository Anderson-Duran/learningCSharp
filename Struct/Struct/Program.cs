public struct NomeDaStruct
{
    public string marca;
    public string modelo;
    public int ano;

    public NomeDaStruct(string marca, string modelo, int ano)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
    }
}

class Program
{
    static void Main()
    {
        //DECLARAÇÃO SEM OPERADOR NEW

        NomeDaStruct carro;

        carro.marca = "Fiat";
        carro.modelo = "Uno";
        carro.ano = 2022;

        Console.WriteLine($"Marca do Carro....: {carro.marca}");
        Console.WriteLine($"Modelo do Carro...: {carro.modelo}");
        Console.WriteLine($"Ano do Carro......: {carro.ano}");

        //DECLARAÇÃO USANDO OPERADOR NEW

        NomeDaStruct carro1 = new NomeDaStruct("Honda", "HRV", 2022);

        Console.WriteLine($"Marca...: {carro1.marca}");
        Console.WriteLine($"Modelo..: {carro1.modelo}");
        Console.WriteLine($"Ano.....: {carro1.ano}");
    }
}