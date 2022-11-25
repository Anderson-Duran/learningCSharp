using System;

public class Jogador
{
    public string name;
    public int energy;
    public bool alive;

    public Jogador()
    {
        name = "Jogador";
        energy = 100;
        alive = true;
    }

    public Jogador(string n)
    {
        name =n;
        energy = 100;
        alive=true;
    }
    public Jogador(string n, int e, bool a)
    {
        name = n;
        energy = e;
        alive = a;
    }

    public Jogador(string n, int e)
    {
        name = n;
        energy = e;
    }

    public void Info()
    {
        Console.WriteLine($"Nome do jogador...: {name}");
        Console.WriteLine($"Energia do jogador: {energy}");
        if (alive == true)
        {
            Console.WriteLine($"Estado do jogador.: Vivo\n");
        }
        else
        {
            Console.WriteLine($"Estado do jogador.: Morto\n");
        }
       
    }
}

class Program
{
    static void Main()
    {
        Jogador jogador = new Jogador();
        Jogador jogador0 = new Jogador("Bruno");
        Jogador jogador1 = new Jogador("Thales", 50);
        Jogador jogador2 = new Jogador("Anderson", 100, true);
        Jogador jogador3 = new Jogador("Zico", 0, false);

        jogador.Info();
        jogador0.Info();
        jogador1.Info();
        jogador2.Info();
        jogador3.Info();
    }
}


