abstract class Veiculo //CLASSE BASE DO TIPO ABSTRCT NÃO PODE INSTANCIAR OBJETOS
{
    protected int topSpeed;  //PODE SER CHAMADA EM CLASSES DERIVADAS
    protected int actualSpeed;
    protected bool turnedOn;
    protected string name;

    
    public void setTurnderOn(bool turnedOn)
    {
        this.turnedOn = turnedOn;
    }

    abstract public void setActualSpeed(int actualSpeed); //METODO CRIADO SEM IMPLEMETOS

    public int getActualSpeed()  //MÉTODO PARA ACESSAR O VALOR DE ACTUALSPEED
    {
        return actualSpeed;
    }

    public string getTurnedOn()  //MÉTODO PARA ACESSAR O VALOR DE TURNEDON
    {
        return (turnedOn?"Yes":"No");
    }
   abstract public void setTopSpeed(int topSpeed);
}

class Car : Veiculo
{
    public Car()
    {
        topSpeed = 130;
        actualSpeed = 0;
        Console.Write("Digite um nome para o veiculo: ");
        name = Console.ReadLine();
    }

    public string getName()
    {
        return name;
    }
    override public void setActualSpeed(int actualSpeed)
    {
        this.actualSpeed += actualSpeed * 5;
        if (this.actualSpeed < 0)
        {
            actualSpeed = 0;
        }
        else if (this.actualSpeed > topSpeed)
        {
            this.actualSpeed = topSpeed;
        }
    }

    public override void setTopSpeed(int topSpeed)
    {
        this.topSpeed = topSpeed;
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        car.setTurnderOn(true);
        car.setTopSpeed(320);
        car.setActualSpeed(5);
        
        
        Car car1 = new Car();

        car1.setTurnderOn(true);
        car1.setTopSpeed(400);
        car1.setActualSpeed(5000);
       

        Console.WriteLine("-------------------------------------------");

        Console.WriteLine($"Vehicle {car.getName()} On? {car.getTurnedOn()}");
        Console.WriteLine($"Vehicle speed? {car.getActualSpeed()}Km/h");

        Console.WriteLine("-------------------------------------------");

        Console.WriteLine($"Vehicle {car1.getName()} On? {car1.getTurnedOn()}");
        Console.WriteLine($"Vehicle speed? {car1.getActualSpeed()}Km/h");
    }
}