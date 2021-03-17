using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> allTires = new List<Tire[]>();
            List<Engine> allEngines = new List<Engine>();
            List<Car> allCars = new List<Car>();

            const double distance = 20.0;

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                string[] tires = input.Split(" ").ToArray();

                Tire[] fourTires = new Tire[4]
                {
                        new Tire(int.Parse(tires[0]), double.Parse(tires[1])),
                        new Tire(int.Parse(tires[2]), double.Parse(tires[3])),
                        new Tire(int.Parse(tires[4]), double.Parse(tires[5])),
                        new Tire(int.Parse(tires[6]), double.Parse(tires[7])),
                };

                allTires.Add(fourTires);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] engines = input.Split(" ").ToArray();

                int engineHorsePower = int.Parse(engines[0]);
                double engineCubicCapacity = double.Parse(engines[1]);

                Engine engine = new Engine(engineHorsePower, engineCubicCapacity);
                allEngines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] carInfo = input.Split().ToArray();

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tireIndex = int.Parse(carInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, allEngines[engineIndex], allTires[tireIndex]);

                bool isSpecialCar = IsSpecialCar(car);

                if (isSpecialCar)
                {
                    car.Drive(distance);
                }

                if (car.FuelQuantity != fuelQuantity)
                {
                    allCars.Add(car); //ako ne e special nqma da kara
                }

                input = Console.ReadLine();
            }

            foreach (var specialCar in allCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}\r\n"
                                + $"Model: {specialCar.Model}\r\n"
                                + $"Year: {specialCar.Year}\r\n"
                                + $"HorsePowers: {specialCar.Engine.HorsePower}\r\n"
                                + $"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }

        private static bool IsSpecialCar(Car car)
        {
            return car.Year >= 2017 &&
                car.Engine.HorsePower >= 330 &&
                car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                car.Tires.Select(x => x.Pressure).Sum() <= 10;
        }
    }
}
