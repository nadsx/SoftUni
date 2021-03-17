using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
           
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string model = input[1];
                double distance = double.Parse(input[2]);

                int indexOfCurrentCar = cars.IndexOf(cars.Find(x => x.Model == model));
                cars[indexOfCurrentCar].Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
