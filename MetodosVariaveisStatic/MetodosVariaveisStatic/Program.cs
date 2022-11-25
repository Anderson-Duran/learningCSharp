class NomeClasse
{
    public static double variavelPropriedade = 3.14;

    public static int NomeDaFuncaoMetodo(int n)     //NO CASO VAMOS FAZER UMA FUNÇÃO/METODO QUE DOBRE O VALOR PASSADO
    {
        return n * 2;
    }
}

class Program
{
    static void Main()
    {
        //NÃO PRECISA SER INSTANCIADO UM OBJETO COMO

        NomeClasse nomeClasse = new NomeClasse();
        
        //PODE-SE CHAMAR DIRETO O MEBRO DA CLASSE CONFORME ABAIXO
        
        double valorDePi;
        int valorASerDobrado = 20;

        valorDePi = NomeClasse.variavelPropriedade;


        Console.WriteLine($"O dobro do valor {valorASerDobrado} = {NomeClasse.NomeDaFuncaoMetodo(valorASerDobrado)}");
    }
}