class Base
{
    public Base()
    {
        Console.WriteLine("Contrutor Base\n");
    }
}

class Derivada1 :Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor Derivada 1\n");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor Derivada 2\n");
    }
}

class Program
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();

        
    }
}