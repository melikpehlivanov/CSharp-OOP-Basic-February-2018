using System;

public class Car : Vehicle
{
    private const double fuelConsumptionIncrease = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + fuelConsumptionIncrease, tankCapacity)
    {
    }

    protected override double FuelQuantity
    {
        set
        {
            if (value > base.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            base.FuelQuantity = value;
        }
    }
}