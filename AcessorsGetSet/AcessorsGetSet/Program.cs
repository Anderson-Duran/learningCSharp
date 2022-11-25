class Car
{
    int topSpeed;
    bool turnedOn;

    //public void setTopSpeed(int topSpeed)   //METODOS DE ATRIBUIÇÃO E LEITURA DE VALORES POR METODOS
    //{
    //    this.topSpeed = topSpeed;
    //}

    //public int getTopSpeed()                //METODO DE LEITURA DE VALOR POR METODOS
    //{
    //    return topSpeed;
    //}

    public int getSet
    {
        get
        {
            return topSpeed;
        }
        set
        {
            if (value < 0)
            {
                topSpeed = 0;
            }
            else if (value > 120)
            {
                topSpeed = 120;
            }
            else
            {
                topSpeed = value;
            }
        }
    }
    public bool OnOff
    {
        set
        {
            turnedOn = value;
        }
        get
        {
            return turnedOn;
        }
    }



    class Program
    {
        static void Main()
        {
            Car car = new Car();

            //car.setTopSpeed(120); //PARA SE PASSAR OS VALORES AO INVES DESSA SINTAXE, UTILIZANDO OS ACESSORS GET SET PASSA-SE A UTILIZAR...

            car.getSet = 120;       //PARA SETAR UM PARAMETRO NO OBJETO CAR
            car.OnOff = true;       //PARA SETAR UM PARAMETRO NO OBJETO CAR


            Console.WriteLine($"A velocidade máxima será: {car.getSet}KM/h\n");

            if (car.OnOff == false) //RETORNA OS VALORES CONSTADOS NOS ACESSORS GET SET
            {
                Console.WriteLine($"O veículo está desligado");
            }
            else
            {
                Console.WriteLine($"O veículo está ligado");
            }


        }
    }
}