namespace CalculoArea
{
    class Area
    {
        public static double Ret(double bas, double alt)
        {
            if (bas <= 0 || alt <= 0)
            {
                throw new ArgumentException("Os valores da base e altura devem ser maiores que 0");
            }
            return bas * alt;
        }
    }
}


namespace CalculoArea1
{
    class Area
    {
        public static float Tri(float bas, float alt)
        {
            if ((bas <= 0) || (alt <= 0))
            {
                throw new ArgumentException("Os valores da base e altura devem ser maiores que 0!");
            }
            return (bas * alt) / 2;
        }
    }
}




namespace Principal
{
    class Program
    {
        public static void Main(string[] args)
        {
        //INICIO DO CALCULO RETANGULO

        start:

            double area, bas, alt;
            area = bas = alt = 0;

            Console.Write("Digite o valor da base do retângulo (em Mtrs): ");
            bas = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo (em Mtrs): ");
            alt = double.Parse(Console.ReadLine());

            try
            {
                area = CalculoArea.Area.Ret(bas, alt);
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro: {erro.Message}");
                goto start;
            }
            finally
            {
                Console.WriteLine("\nFim do processo!\n");
            }
            Console.WriteLine($"Área = {area.ToString("N2")} mts2\n");

            //INICIO DO CALCULO TRIANGULO
            
            startTriangulo:

            float areaTri, basTri, altTri;
            areaTri = basTri = altTri = 0f;

            Console.Write("Digite o valor da base do retângulo (em Mtrs): ");
            basTri = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura do retângulo (em Mtrs): ");
            altTri = float.Parse(Console.ReadLine());

            try
            {
                areaTri = CalculoArea1.Area.Tri(basTri, altTri);
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: {0}", erro.Message);
                goto startTriangulo;
            }
            finally
            {
                Console.WriteLine("\nProcesso concluido!\n");
            }
            Console.WriteLine($"Área = {areaTri.ToString("N2")} mts2\n");
        }
    }
}