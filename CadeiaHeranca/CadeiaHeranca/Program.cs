public class Vehicle
{
    private int tyres;
    private bool on;
    public int topspeed;

    public Vehicle(int tyres)
    {
        this.tyres = tyres;
    }

    public void turnedOn()
    {
        on = true;
    }

    public void turnedOff()
    {
        on = false;
    }

    public string getTurnedOn()
    {
        return (on ? "Yes" : "No");
    }        

    public int getNumberOfTyres()
    {
        return tyres;
    }

    public void setTyres(int tyres)
    {
        if (tyres < 0)
        {
            tyres = 0;
        }
        else if (tyres > 12)
        {
            tyres = 12;
        }
        else
        {
            this.tyres = tyres;
        }
    }

}

class Car : Vehicle
{
    public string name;
    public string color;
    public Car(string name, string color) : base(4)
    {
        this.name = name;
        this.color = color;
        topspeed = 120;
        turnedOff();
    }
}


class CombatCar : Car
{
    public int munition;
    public CombatCar():base("Rambo", "Green")
    {
        munition = 100;

    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Mavericks", "Red");

        car.turnedOn();

        car.setTyres(8);

        car.topspeed = 280;

        Console.WriteLine($"Car's name: {car.name}");
        Console.WriteLine($"Vehicle topspeed: {car.topspeed}");
        Console.WriteLine($"Number of tyres: {car.getNumberOfTyres()}");
        Console.WriteLine($"The {car.name} is on? {car.getTurnedOn()}");


        CombatCar combat = new CombatCar();

        combat.turnedOn();

        combat.setTyres(4);

        Console.WriteLine($"\n\nCombat car's name: {combat.name}");
        Console.WriteLine($"Topspeed: {combat.topspeed}");
        Console.WriteLine($"Number of tyres: {combat.getNumberOfTyres()}");
        Console.WriteLine($"The {combat.name} is on? {combat.getTurnedOn()}");
    }

}
