namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int index = 0; index < numberOfCars; index++)
            {
                var carInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPer1Km = double.Parse(carInfo[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPer1Km);
                cars.Add(car);
            }
            string driveCommand = Console.ReadLine();
            while (driveCommand != "End")
            {
                string[] driveCommandsArgs = driveCommand.Split();
                string carModel = driveCommandsArgs[1];
                int amountOfKilometers = int.Parse(driveCommandsArgs[2]);
                Car carToDrive = cars.First(c => c.Model == carModel);
                carToDrive.Drive(amountOfKilometers);

                driveCommand = Console.ReadLine();
            }

            cars.ForEach(c=> Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.DistanceTraveled}"));
        }
    }
}
