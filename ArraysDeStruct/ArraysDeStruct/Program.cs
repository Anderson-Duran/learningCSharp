public struct NomeDaStruct
{

    //CRIAÇÃO DO METODO E PROPRIEDADES

    public string modelo;
    public string cor;
    public int ano;

    public void Info()
    {
        Console.WriteLine($"Modelo: {this.modelo}");
        Console.WriteLine($"Cor...: {this.cor}");
        Console.WriteLine($"Ano...: {this.ano}");
        Console.WriteLine("------------------------");
    }

}

class Program
{
    static void Main()
    {
        NomeDaStruct[] carro = new NomeDaStruct[4];

        // PASSARNDO PROPRIEDADES DO OBJETO CARRO UM A UM

        carro[0].modelo = "Honda";
        carro[0].cor = "Cinza";
        carro[0].ano = 2022;

        carro[1].modelo = "Ferrari";
        carro[1].cor = "Vermelha";
        carro[1].ano = 2022;

        carro[2].modelo = "Porsche";
        carro[2].cor = "Amarelo";
        carro[2].ano = 2022;

        carro[3].modelo = "VW";
        carro[3].cor = "Cinza";
        carro[3].ano = 2022;

        carro[0].Info();
        carro[1].Info();
        carro[2].Info();
        carro[3].Info();

        NomeDaStruct[] carro1 = new NomeDaStruct[3];

        //PASSANDO PROPRIEDADES DO OBEJO CARRO1 VIA LOOP

        for (int i = 0; i < carro1.Length; i++)
        {
            Console.Write($"Digite o modelo do carro {i+1}: ");
            carro1[i].modelo = Console.ReadLine();
            Console.Write($"Digite a cor do carro {i+1}: ");
            carro1[i].cor = Console.ReadLine();
            Console.Write($"Digite o ano do carro {i+1}: ");
            carro1[i].ano = Convert.ToInt16(Console.ReadLine());
        }

        for (int i = 0; i < carro1.Length; i++)
        {
            carro1[i].Info();
        }
    }
}