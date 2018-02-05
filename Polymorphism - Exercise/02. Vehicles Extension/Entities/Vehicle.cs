using System;

public abstract class Vehicle
{
    private double fuelQuantity;

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity; 
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    protected virtual double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.fuelQuantity = value;
        }
    }

    protected double FuelConsumption { get; set; }

    protected double TankCapacity { get; set; }

    public virtual void Drive(double distance, bool hasAC)
    {
        if (this.FuelQuantity < distance * this.FuelConsumption)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.FuelQuantity -= distance * this.FuelConsumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

    public virtual void Drive(double distance)
    {
        this.Drive(distance, true); // AC on (car, truck) vs AC on/off (bus)
    }

    public virtual void Refuel(double liters)
    {
        if (liters <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:f2}";
    }
}