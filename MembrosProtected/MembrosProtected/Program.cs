class Vehicle
{
    public int speedNow;
    private int topSpeed;
    protected bool turnedOn;

    public Vehicle(int topSpeed)
    {
        speedNow = 0;
        this.topSpeed = topSpeed;
        this.turnedOn = false;
    }

    public string getturnedOn()
    {
        return (turnedOn ? "Yes" : "No");
    }

    public void setTurnedOn(bool turnedOn)
    {
        this.turnedOn = turnedOn;
    }
    public int getTopSpeed()
    {
        return topSpeed;
    }
}

class Car: Vehicle
{
    public string name;

    public Car(string name,int topSpeed ):base(topSpeed) //Forma de iniciar o contrutor da class base que necessite de um paremetro/arg
    {
        this.name = name;
        topSpeed = topSpeed; //Nao pode ser acessado a var topspeed da class base por ser private, somente topspeed do segundo escopo
        turnedOn = true;   //A var turnedOn pode ser acessada diretamente da class deriv por ser um membro do tipo protected
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Ferrari", 320);

        car.setTurnedOn(false);

        Console.WriteLine($"Car's model/brand: {car.name}");
        Console.WriteLine($"Car's topspeed: {car.getTopSpeed()}");
        Console.WriteLine($"The {car.name} is on? {car.getturnedOn()}");
    }
}