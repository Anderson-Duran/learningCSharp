class Pai
{
    string nome;
    string cor;
    private int dedos;


    public Pai(string nome, string cor)
    {
        this.nome = nome;
        this.cor = cor;
        this.dedos = 0;
    }

    public Mae filho()
    {
        dedos += 20;
        return new Mae(nome, cor, dedos);
    }
}

class Mae
{
    public Mae(string nome, string cor, int dedos)
    {
        Console.WriteLine("Nasceu um filho");
        Console.WriteLine($"Seu nome é {nome} e possui olhos de cor {cor} agora são {dedos} dedos");
        Console.WriteLine("-----------------------------------------------------------------------");
    }
}

class Principal
{
    static void Main()
    {
        string nome;
        string cor;

        Console.Write("Digite o nome do seu filho: ");
        nome = Console.ReadLine();

        Console.Write("Digite a cor dos olhos do seu filho: ");
        cor = Console.ReadLine(); 


        Pai pai = new Pai(nome, cor);
        Pai pai1 = new Pai(nome, cor);
        Pai pai2 = new Pai(nome, cor);

        pai.filho();
        pai1.filho();
        pai2.filho();
    }
}