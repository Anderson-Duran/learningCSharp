class Program
{
    static void Main(string[] args)
    {

        if (args.Length > 0)
        {
            Console.WriteLine($"Foram passados {args.Length} argumentos");
            int res = 0;
            for (int i = 0; i < args.Length; i++)
            {
                res += Convert.ToInt32(args[i]);
            }
            Console.WriteLine($"A soma = { res}");
        }
    }
}
