delegate double OpF(double valor1, double valor2);


class Adicao
{
    public static double Soma(double valor1, double valor2)
    {
        return (valor1 + valor2);
    }
}

class Subtracao
{
    public static int Subt(int valor1, int valor2)
    {
        if (valor1 < 0)
        {
            valor1 += -1;

            return valor1 - valor2; 
        }
        else if (valor2 < 0)
        {
            valor2 *= -1;

            return valor1 - valor2;
        }
        else
        {
            return valor1 - valor2;
        }
    }

    public static double Subt(double valor1, double valor2)
    {
        if (valor1 < 0)
        {
            valor1 *= (-1);

            return valor1 - valor2;
        }
        else if (valor2 < 0)
        {
            valor2 *= (-1);

            return valor1 - valor2;
        }
        else
        {
            return valor1 - valor2;
        }
    }
}

class Divisao
{
    public static int Div(int valor1, int valor2)
    {
        return valor1 / valor2; 
    }

    public static double Div(double valor1, double valor2)
    {
        double result = valor1 / valor2;
        return result;
    }

}

class Multiplicacao
{
    public static int Mult(int valor1, int valor2)
    {
        return valor1 * valor2;
    }

    public static double Mult(double valor1, double valor2)
    {
        return valor1 * valor2;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora");

        inicio:

        Console.WriteLine("\nSelecione a opção de operação\n");
        Console.Write("Digite...\n1 Soma\n2 Subtração\n3 Divisão\n4 Multiplicação: ");
        string resp = Console.ReadLine();
        
        
        if (resp == "1")
        {
            OpF operacao = new OpF(Adicao.Soma);

            double n1;
            double n2;

            Console.Write("\nInsira valores para Somar: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            var result = Adicao.Soma(n1, n2);

            if (result.GetType() == typeof(double))
            {
                Console.WriteLine($"{n1} + {n2} = {result.ToString("N2")}");
            }
            else
            {
                result = Convert.ToInt16(result);
                Console.WriteLine($"\n{n1} + {n2} = {result}\n");
            }

            Console.Write("\nDeseja fazer outra operação?[S/N] ");
            string resp2 = Console.ReadLine().ToUpper();

            if (resp2 == "S")
            {
                Console.Clear();
                goto inicio;
            }
            else
            {
                Console.WriteLine("\nAté Mais!");
            }
        }

        if (resp == "2")
        {
            OpF operacao = new OpF(Subtracao.Subt);

            var n1 = 0;
            var n2 = 0;

            Console.Write("\nInsira valores para Subtrair: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"\n{n1} - {n2} = {operacao(n1, n2)}\n");

            Console.Write("\nDeseja fazer outra operação?[S/N] ");
            string resp2 = Console.ReadLine().ToUpper();

            if (resp2 == "S")
            {
                Console.Clear();
                goto inicio;
            }
            else
            {
                Console.WriteLine("\nAté Mais!");
            }
        }

        if (resp == "3")
        {
            OpF operacao = new OpF(Divisao.Div);

            var n1 = 0;
            var n2 = 0;

            Console.Write("\nInsira valores para Divisão: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            var result = operacao(n1, n2);

            if (n1 % n2 == 1)
            {
                Console.WriteLine($"\n{n1} / {n2} = {result.ToString("N2")}\n");
            }
            else
            {
                result = Convert.ToInt16(result);
                Console.WriteLine($"\n{n1} / {n2} = {result}\n");
            }

            Console.Write("\nDeseja fazer outra operação?[S/N] ");
            string resp2 = Console.ReadLine().ToUpper();

            if (resp2 == "S")
            {
                Console.Clear();
                goto inicio;
            }
            else
            {
                Console.WriteLine("\nAté Mais!");
            }
        }

        if (resp == "4")
        {
            OpF operacao = new OpF(Multiplicacao.Mult);

            var n1 = 0;
            var n2 = 0;

            Console.Write("\nInsira valores para multiplicar: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n{n1} x {n2} = {operacao(n1, n2)}\n");

            Console.Write("\nDeseja fazer outra operação?[S/N] ");
            string resp2 = Console.ReadLine().ToUpper();

            if (resp2 == "S")
            {
                Console.Clear();
                goto inicio;
            }
            else
            {
                Console.WriteLine("\nAté Mais!");
            }
        }


    }
}