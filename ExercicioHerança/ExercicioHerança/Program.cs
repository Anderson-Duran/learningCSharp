class Veiculo //classe base
{
    private int rodas;
    public int velMax;
    public int velMin;
    public bool ligado;

    public Veiculo(int rodas) //Construtor
    {
        this.rodas = rodas;
    }
    public void Ligar()
    {
        ligado = true;
    }

    public void Desligado()
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
    public int getRodas() 
    { 
        return rodas; 
    }
}

class Carro : Veiculo  //classe derivada
{
    public string nomeCondutor;
    public string equipe;
    public Carro(string nomeCondutor, string equipe):base(4) //contrutor Carro e para evitar erro de 0 argumentos usa-se a inicializacao do const classe base
    {
        this.nomeCondutor = nomeCondutor;
        this.equipe = equipe;
        velMax = 350; 
        velMin = 0;
        getLigado();
        
    }
}

class Exe
{
    static void Main()
    {
                
        Carro carro1 = new Carro("Max Verstappen", "Red Bull");

        carro1.Ligar();

       
        Console.WriteLine($"Condutor.........: {carro1.nomeCondutor}");
        Console.WriteLine($"Equipe...........: {carro1.equipe}");
        Console.WriteLine($"Veículo..........: {carro1.getRodas():00} rodas");
        Console.WriteLine($"Velocidade Máxima: {carro1.velMax}");
        Console.WriteLine($"Velocidade Mínima: {carro1.velMin}");
        Console.WriteLine($"Motor ligado.....: {carro1.getLigado()}");
    }
}