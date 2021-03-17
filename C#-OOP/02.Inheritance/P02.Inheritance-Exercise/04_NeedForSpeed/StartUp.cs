using NeedForSpeed.Cars;
using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            Vehicle car = new Car(300, 100);

            car.Drive(10);

            Console.WriteLine(car.Fuel);
        }
    }
}
