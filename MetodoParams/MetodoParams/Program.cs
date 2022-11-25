public class Operacoes
{
    
    //CRAINDO METODO SOMA COM A PALAVRA CHAVE PARAMS

    //PASSADO PARAMS SEGUIDO DE UM ARRAY
    public int Soma(params int[]numeros)        
    {
    
        var result = 0;
        
        for (int i = 0; i < numeros.Length; i++)
        {
            
            result += numeros[i];
         
        }
        return result;       
    }
}
    
    //CRIADO CLASSE PRINCIPAL E INSTANCIADO O OBJEOT RESULTADO

class Program
{
    static void Main()
    {
        Operacoes resultado = new Operacoes();

        var total = 0;
        
        total = resultado.Soma(1,3,5);

        Console.WriteLine(total);
    }
}