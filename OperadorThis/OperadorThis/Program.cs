class Calculo
{
    int valor1;
    int valor2;

    public Calculo(int valor1, int valor2)
    {
        this.valor1 = valor1;
        this.valor2 = valor2;
    }

    public int soma()
    {
        return valor1 + valor2;
    }

    public int subtracao()
    {
        return valor1 - valor2;
    }
}


class AulaThis
{
    static void Main()
    {
        Console.Write("Digite os valores a serem somados/subtraídos: ");
        int v1 = Convert.ToInt16(Console.ReadLine());
        int v2 = Convert.ToInt16(Console.ReadLine());

        Calculo valores = new Calculo(v1,v2);

        Console.WriteLine($"\nA soma dos valore = {valores.soma()}\nA subtração dos valores = {valores.subtracao()}");
    }
}