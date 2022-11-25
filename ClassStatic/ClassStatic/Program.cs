static public class Jogador       //CRIA A CLASSE COM O MODIFICADOR STATIC
{
    public static string name;    //CRIA AS PROPRIEDADES DA CLASSE COM ESPECIFICADOR STATIC
    public static bool alive;     //CRIA AS PROPRIEDADES DA CLASSE COM ESPECIFICADOR STATIC
    public static int energy;     //CRIA AS PROPRIEDADES DA CLASSE COM ESPECIFICADOR STATIC

    static public void iniciar(string n, bool a, int e)  //CRIA METODO COM ESPECIFICADOR DE ACESSO TAMBEM STATIC
    {
        name = n;
        alive = a;
        energy = e;
    }

    static public void info()                           //CRIA METODO COM ESPECIFICADOR DE ACESSO TAMBEM STATIC
    {
        Console.WriteLine($"Nome Player...: {name}");
        Console.WriteLine($"Estado Player.: {alive}");
        Console.WriteLine($"Energia Player: {energy}");
    }
}

public class Inimigo
{
    public string name;
    static public bool alert;
    public int energy;

    public Inimigo(string n)
    {
        name = n;
        alert = false;
        energy = 100;
    }

    public void info()
    {
        if (alert == true)
        {
            Console.WriteLine($"\nO inimigo {name} está em estado de alerta!\nEnergia dele {energy}%");
            Console.WriteLine($"--------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine($"\nO inimigo {name} não está em estado de alerta!\nEnergia dele {energy}%");
            Console.WriteLine($"--------------------------------------------------------------------");
        }
        
    }
}

class Principal
{
    static void Main()
    {
        Jogador.iniciar("Anderson", true, 100); //PASSAR O PARAMETRO PARA ACESSAR OS DADOS DO OBJETO STATIC
        Jogador.info();

        Inimigo inimigo = new Inimigo("Loucura");
        Inimigo inimigo1 = new Inimigo("Pé de Brek");
        
        Inimigo.alert = false;  //PARA ALTERAR O ESTADO DE ALERTA PRECISO ACESSAR A PROPRIEDADE ATRAVÉS DA CLASSE CASO ESTA SEJA STATIC
        //caso a propriedade ñão fosse do tipo static poderia passar direto
        inimigo.info();
        inimigo1.info();
    }
}







