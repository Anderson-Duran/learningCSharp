using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{

    class Area
    {
        public static double Quad(double lado)
        {
            
            if (lado <= 0)
            {
                throw new ArgumentException("O valor do lado deve ser maior que 0\n");  //MENSAGEM QUE SERÁ EXIBIDA DURANTE O ERRO
            }
            return Math.Pow(lado, 2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:

            Console.Write("Digite o lado do quadrado (em metros) para saber sua área: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            double area = 0;

            try
            {
                area = Area.Quad(lado);
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");         //CHAMANDO A MENSAGEM DE ERRO DEFINIDA 
                
                goto inicio;
                
            }
            finally
            {
                if (lado <= 0)
                {

                }
                else
                {
                    Console.WriteLine("Processo Executado!");
                }
                

            }
            Console.WriteLine($"\nÁrea do Quadrado = {area} MTS/2");

            Console.ReadKey();

        }
    }
}
