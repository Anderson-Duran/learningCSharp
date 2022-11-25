class aula26
{
    static void Main()
    {
        int num = 10;

        dobrarValor(num); //passagem por valor onde é criado novo endereço na memoria
        Console.WriteLine(num); //imprime 10

        dobrarReferencia(ref num); //passagem por referencia onde é atribuido o operador ref, aproveitando o endereço na memoria
        Console.WriteLine(num); //imprime 20
        
        
    }

    static int dobrarReferencia(ref int valor) //passagem por referencia onde é atribuido o operador ref, aproveitando o endereço na memoria
    {
        valor *= 2;
        return valor;
    }

    static int dobrarValor(int valor) //passagem por valor onde é criado novo endereço na memoria
    {
        valor *= 2;
        return valor;
    }
}
