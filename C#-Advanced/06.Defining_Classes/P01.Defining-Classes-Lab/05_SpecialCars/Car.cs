using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = string.Empty;
            this.Model = string.Empty;
            this.Year = 0;
            this.FuelQuantity = 0.0;
            this.FuelConsumption = 0.0;
        }

        public Car(string make, string model, int year, 
            double fuelQuantity, double fuelConsumption, 
            Engine engine, Tire[] tires) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.Engine = engine;
            this.Tires = tires;
        }

        public string Make { get; set; } 

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            //The two ways of reporting fuel economy are in litres per 100km or kilometres per litre.

            //If you know the price of fuel, then you can simply multiply the price per litre 
            //by the result and that gives you your cost per 100km. E.g. if fuel is $2, 
            //then 8.98l/100km means that it takes $17.96 of fuel to travel 100km, 
            //or around $0.18 per kilometre, not including your other costs like wear and tear.

            if (distance * FuelConsumption / 100 > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= FuelConsumption / 100 * distance;
            }
        }
    }
}
