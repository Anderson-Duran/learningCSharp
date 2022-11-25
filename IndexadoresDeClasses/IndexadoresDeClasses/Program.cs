//class Vehicle
//{
//    private int[] topSpeed = new int[5] { 50, 20, 300, 800, 150 }; //DECLARA UM ARRAY


//    public int this[int i]                                   //O QUE DEFINE ISSO COMO UM INDEXADOR O OPERADOR THIS, PRECEDIDO DO INDICE
//    {
//        get
//        {
//            return topSpeed[i];
//        }
//        set
//        {
//            if (value < 0)
//            {
//                topSpeed[i] = 0;
//            }
//            else if (value > 250)
//            {
//                topSpeed[i] = 250;
//            }
//            else
//            {
//                topSpeed[i] = value;
//            }

//        }
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        Vehicle vehicle = new Vehicle();

//        vehicle[2] = 350;  //Parametro Set

//        Console.WriteLine(vehicle[2]);    //Parametro get
//        //for (int i = 0; i < 5; i++)
//        //{
//        //    Console.Write("Digite um valor de velocidade: ");
//        //    vehicle[i] = Convert.ToInt16(Console.ReadLine());
//        //}

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    Console.WriteLine($"Foi digitado o valor {vehicle[i]} na posicao {i}");
//        //}

//    }
//}


class Veiculo
{
    protected int[] velMax = new int[4];
   

    public int this[int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 150)
            {
                velMax[i] = 150;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }
}

class Carro : Veiculo
{
  
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro();

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite a velocidade maxima: ");
            carro[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int count = 0; count < 4; count++)
        {
            Console.WriteLine($"velocidade maxima/minima do veiculo {count+1} = {carro[count]}");
        }
    }
}