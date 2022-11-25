class aula26
{
    static void Main()
    {
        double dividendo, divisor, resto, quoc;
        dividendo = 10;
        divisor = 3;
        quoc = quociente(dividendo, divisor,out resto);
        Console.WriteLine($"A divisão de {dividendo} / {divisor} terá quociente {quoc.ToString("n2")} e resto {resto}");

        static double quociente(double valor1, double valor2, out double rest)
        {
            rest = valor1 % valor2;
            return valor1 / valor2;

        }

    }
}
