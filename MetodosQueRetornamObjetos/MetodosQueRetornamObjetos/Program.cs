public class Galinha
{
    private string nomeGalinha;
    private int numOvo;
    public static int sequencia = 0;

    //CONTRUTOR GALINHA
    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        this.numOvo = 0;
    }

    //METODO PARA RETORNAR OBJETO DO TIPO OVO

    public Ovo Botar()
    {
        numOvo++;
        sequencia++;
        return new Ovo(numOvo, nomeGalinha, sequencia);
    }

    //SOU O NUMERO X DA GALINHA Y PORÉM Z DA SEQUENCIA DE OVOS
    
    


}

public class Ovo : Galinha
{

    public Ovo(int numOvo, string nomeGalinha,int numTotal ):base(nomeGalinha)  //PASSANDO ARGUMENTO EXIGIDO PELA CLASSE GALINHA
    {
        Console.WriteLine($"Foi criado {numOvo} ovo para a galinha {nomeGalinha,10}, sendo o ovo número {numTotal}");
        Console.WriteLine("-------------------------------------------------------------------------------------");
    }
       
    
}

public class Program
{
    static  void Main()
    {
        Galinha galinha = new Galinha("Gertrudes");
        Galinha galinha1 = new Galinha("Germanica");
        Galinha galinha2 = new Galinha("Araldita");
        Galinha galinha3 = new Galinha("Helenica");

        galinha.Botar();
        galinha.Botar();
        galinha.Botar();


        galinha1.Botar();
        galinha1.Botar();
        galinha1.Botar();
        galinha1.Botar();

        galinha2.Botar();
                        
        galinha3.Botar();
        galinha3.Botar();

       
    }
}