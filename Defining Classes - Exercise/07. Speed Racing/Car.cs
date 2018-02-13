using System;

class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPer1Km;
    private double distanceTraveled;

    public string Model => this.model;
    public double FuelAmount => this.fuelAmount;
    public double DistanceTraveled => this.distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumptionPer1Km)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPer1Km = fuelConsumptionPer1Km;
        this.distanceTraveled = 0;
    }

    public void Drive(int amountOfKilometers)
    {
        if (amountOfKilometers <= this.fuelAmount / this.fuelConsumptionPer1Km)
        {
            this.distanceTraveled += amountOfKilometers;
            this.fuelAmount -= this.fuelConsumptionPer1Km * amountOfKilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}

