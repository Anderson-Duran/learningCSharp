
Console.Write("DIGITE UM VALOR PRA A: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("DIGITE UM VALOR PRA B: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("DIGITE UM VALOR PRA C: ");
double c = Convert.ToDouble(Console.ReadLine());
const double pi = 3.14159;

double triangulo = (a * c)/2;
double circulo = pi * (Math.Pow(c, 2));
double trapezio = ((a + b) * c) / 2;
double quadrado = Math.Pow(b, 2);
double retangulo = a * b;

Console.WriteLine($"TRIANGULO: {triangulo.ToString("N3")}");
Console.WriteLine($"CIRCULO: {circulo.ToString("N3")}");
Console.WriteLine($"TRAPEZIO: {trapezio.ToString("N3")}");
Console.WriteLine($"QUADRADO: {quadrado.ToString("N3")}");
Console.WriteLine($"RETANGULO: {retangulo.ToString("N3")}");



