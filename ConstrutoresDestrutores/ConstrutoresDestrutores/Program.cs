public class Jogador
{
    public int energy;
    public int age;
    public string name;

    public Jogador(int idade, string nome)
    {
        energy = 100;
        age = idade;
        name = nome;
    }

    ~Jogador() //Desconstrutor
    {

    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Contrutores e Destrutores");

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());

        Console.Write("Digite o nome: ");
        string nome1 = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade1 = Convert.ToInt16(Console.ReadLine());

        Jogador jogador = new Jogador(idade, nome);
        Jogador jogador1 = new Jogador(idade1, nome1);


        Console.WriteLine($"O jogador 1 possui nome {jogador.name} e idade {jogador.age} anos");
        Console.WriteLine($"O jogador 2 possui nome {jogador1.name} e idade {jogador1.age} anos");
      
    }

}

