using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);

                string displacement = engineInfo.Length > 2 ? !char.IsLetter(engineInfo[2][0]) ? engineInfo[2] : "n/a" : "n/a";
                displacement = engineInfo.Length > 3 ? !char.IsLetter(engineInfo[3][0]) ? engineInfo[3] : displacement : displacement;

                string efficiency = engineInfo.Length > 2 ? char.IsLetter(engineInfo[2][0]) ? engineInfo[2] : "n/a" : "n/a";
                efficiency = engineInfo.Length > 3 ? char.IsLetter(engineInfo[3][0]) ? engineInfo[3] : efficiency : efficiency;

                Engine engine = new Engine(engineModel, enginePower, displacement, efficiency);
                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string carModel = carInfo[0];
                string engineModel = carInfo[1];

                string weight = carInfo.Length > 2 ? !char.IsLetter(carInfo[2][0]) ? carInfo[2] : "n/a" : "n/a";
                weight = carInfo.Length > 3 ? !char.IsLetter(carInfo[3][0]) ? carInfo[3] : weight : weight;

                string color = carInfo.Length > 2 ? char.IsLetter(carInfo[2][0]) ? carInfo[2] : "n/a" : "n/a";
                color = carInfo.Length > 3 ? char.IsLetter(carInfo[3][0]) ? carInfo[3] : color : color;

                Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);
                Car car = new Car(carModel, engine, weight, color);

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                car.PrintCar();
            }
        }
    }
}