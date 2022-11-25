using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNota
{
    public class InserçãoNotas
    {
        public static double Nota()
        {
            double[] nota = new double[4];
            for (int i = 1; i < 5; i++)
            {
                Console.Write($"Insira a {i}º nota:  ");
                nota[i-1] = double.Parse(Console.ReadLine());
            }

            double media = ((nota[0] + nota[1] + nota[2] + nota[3])/4);
            return media;
        }
    }
}
