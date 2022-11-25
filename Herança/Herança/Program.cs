class Veiculo   //CLASSE BASE
{
    public int velMax;

    public int roda;

    private bool ligado;

    public void Ligar()
    {
        ligado = true;
    }

    public void Desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        if (ligado)
        {
            return "Sim";
        }
        else
        {
            return "Não";
        }
    }
}

class Carro : Veiculo   //CLASSE DERIVADA
{
    public string cor;

    public string nome;

    private string condutor;

    public string nomeCondutor(string condutor)
    {
        return condutor;
    }
    public Carro(string nome, string cor)
    {
        Desligar();
        roda = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
        nomeCondutor("");
    }
}



class Program //MAIN
{
    static void Main()
    {       
        Carro c1 = new Carro("Red Bull Racing", "Azul");
     
        c1.Ligar();

        Console.WriteLine($"Nome do veículo....: {c1.nome}");
        Console.WriteLine($"Quantidade de Rodas: {c1.roda}");
        Console.WriteLine($"Cor do Veículo.....: {c1.cor}");
        Console.WriteLine($"Velocidade Máxima..: {c1.velMax} KM/h");
        Console.WriteLine($"Veículo ligado.....: {c1.getLigado()}");
        Console.WriteLine($"Nome do piloto.....: {c1.nomeCondutor("Max Verstappen")}");
    }
}