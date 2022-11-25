public interface Veiculo
{
    public void Ligar();

    public void Desligar();

    public void Info();
}

public interface Combate
{
    public void Disparo(int municao);
}


public class Carro:Veiculo,Combate
{
    public bool ligado;
    public int municao;
   
    public void Ligar()
    {
        this.ligado = true;
    }
    
    public void Desligar()
    {
        this.ligado = false;
    }

    public string getligado()
    {
        return (ligado ? "Sim" : "Nao");
    }
    public void Info()
    {
    
    }

    public Carro()
    {
        setMunicao(100);
    }

    public void Disparo(int tiro)
    {
        this.municao -= tiro;
    }
    public void setMunicao(int municao)
    {
        this.municao = municao;
    }

    public void Reload(int municao)
    {
        if (municao < 0)
        {
            this.municao = 0;
        }
        else if (municao > 100)
        {
            this.municao = 100;
        }
        else
        {
            this.municao += municao;
        }
    }

}


public class Program{
    static void Main()
    {
        Carro carro = new Carro();

        carro.Disparo(2);
        carro.Disparo(22);
        carro.Disparo(25);
        carro.Disparo(2);
        carro.Disparo(42);

        carro.ligado = true;

        carro.Reload(7);

        Console.WriteLine("Municao = " + carro.municao);
        Console.WriteLine("Ligado = " + carro.getligado());


        string name = "Anderson Serafim Duran";

        int posicao = name.IndexOf('S');
        string middle = name.Substring(posicao);

        Console.WriteLine($"{posicao} e middle {middle}");
        Console.WriteLine();
        Console.WriteLine(name[2]);


       
    }
}