namespace FoodShortage.Core
{
    using Contracts;
    using Models;

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Engine
    {
        private List<IBuyer> buyers;

        public Engine()
        {
            this.buyers = new List<IBuyer>();
        }

        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] inputArgs = Console.ReadLine().Split().ToArray();

                string name = inputArgs[0];
                int age = int.Parse(inputArgs[1]);

                if (inputArgs.Length == 4)
                {
                    string id = inputArgs[2];
                    DateTime birthday = DateTime.ParseExact(inputArgs[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    IBuyer citizen = new Citizen(name, age, id, birthday);
                    buyers.Add(citizen);
                }
                else if (inputArgs.Length == 3)
                {
                    string group = inputArgs[2];

                    IBuyer rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (buyers.FirstOrDefault(b => b.Name == input) != null)
                {
                    buyers.FirstOrDefault(b => b.Name == input).BuyFood();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}