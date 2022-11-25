class Base
{
    public Base()
    {
        Console.WriteLine("Contrutor Base\n");
    }

    virtual public void info()
    {
        Console.WriteLine("\nMetodo virtual base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor Derivada 1\n");
    }

    override public void info()
    {
        Console.WriteLine("\nMetodo virtual derivada 1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor Derivada 2\n");
    }
    override public void info()
    {
        Console.WriteLine("\nMetodo virtual derivada 2");
    }
}

class Program
{
    static void Main()
    {
        Base Ref = new Base(); //PALAVRA CHAVE REF COM R MAIUSCULO PODE RECEBER REFERENCIAS DE CLASSES DERIVADAS
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada1; //PODE-SE HERDAR OBJETO DA DERIVADA1 E TAMBEM O METODO DESTA CLASSE

        Ref.info(); //SERA CHAMADO O METODO INFO DA CLASSE DERIVADA 1
    }
}