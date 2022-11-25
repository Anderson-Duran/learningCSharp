using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("CALCULADORA\n");
        
        inicio:
        Console.Clear();

        Console.WriteLine($"Selecione a Operação\n\nMultiplicação [M]\nDivisão [D]\nAdição [A]\nSubtração [S]\nPotência [P]\nRaiz [R]\n");
        char operacao = Convert.ToChar(Console.ReadLine());

        switch (operacao)
        {

            case 'A':
            case 'a':
                Console.WriteLine($"\nInsira dois valores para serem somados");
                Console.Write($"Valor 1: ");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Valor 2: ");
                double valor2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nA soma dos valores {valor1} + {valor2} = {soma(valor1, valor2)}");
                break;

            case 'M':
            case 'm':
                Console.WriteLine($"\nInsira os valores para serem multiplicados");
                Console.Write("Valor 1: ");
                double valor3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Valor 2: ");
                double valor4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nO produto dos valores {valor3} x {valor4} = {multip(valor3,valor4)}");
                break;


            case 'S':
            case 's':
                Console.WriteLine($"\nInsira dois valores para serem subtraídos");
                Console.Write($"Valor 1: ");
                double valor5 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Valor 2: ");
                double valor6 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nA subtração dos valores {valor5} - {valor6} = {subt(valor5, valor6)}");
                break;

            case 'D':
            case 'd':
                Console.WriteLine($"\nInsira dois valores para serem divididos");
                Console.Write($"Valor 1: ");
                double valor7 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Valor 2: ");
                double valor8 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nO quociente dos valores {valor7} / {valor8} = {div(valor7, valor8)}");
                break;

            case 'P':
            case 'p':
                Console.WriteLine($"\nInsira a base e o expoente");
                Console.Write($"Base: ");
                double valor9 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Expoente: ");
                double valor10 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nA potência dos valores {valor9} exp {valor10} = {Math.Pow(valor9, valor10)}");
                break;

            case 'R':
            case 'r':
                Console.WriteLine($"\nInsira a radicando e o índice do radical");
                Console.Write($"Radicando: ");
                double valor11 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Índice do radical: ");
                double valor12 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"\nA raiz do radicando {valor11} no índice {valor12} = {Math.Pow(valor11,(1/valor12))}");
                break;

            default:
                Console.Clear();
                Console.WriteLine($"Valor inválido!Insira um valor válido!");
                goto inicio;

        }
        answer:

        string ans;
        Console.WriteLine("\nDeseja realizar mais alguma operação? [Sim/Não]");
        ans = Console.ReadLine();

        if (ans.ToLower() == "sim")
        {
            goto inicio;
        }
        else if (ans.ToLower() == "não")
        {
            Console.WriteLine("\nObrigado e até logo!\n");
        }
        else
        {
            Console.WriteLine("Digite uma resposta válida!\n");
            goto answer;
        }
        
        Console.ReadKey();
        

    }

    static double soma(double n1, double n2)
    {
        double result = n1 + n2;
        return result;
    }

    static double multip(double n1, double n2)
    {
        double result = n1 * n2;
        return result;
    }

    static double subt(double n1, double n2)
    {
        return n1 - n2;
    }
    static double div(double n1, double n2)
    {
        return n1 / n2;
    }
}
