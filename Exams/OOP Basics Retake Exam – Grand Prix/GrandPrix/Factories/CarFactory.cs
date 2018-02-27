using System.Collections.Generic;

public static class CarFactory
{
    public static Car Create(List<string> args, Tyre tyre)
    {
        var hp = int.Parse(args[0]);
        var fuelAmount = double.Parse(args[1]);

        return new Car(hp, fuelAmount, tyre);
    }
}