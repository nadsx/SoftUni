namespace BorderControl.Core
{
    using Contracts;
    using Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<string> ids;

        public Engine()
        {
            this.ids = new List<string>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split().ToArray();

                if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    IRobot robot = new Robot(model, id);
                    ids.Add(id);
                }
                else if (inputArgs.Length == 3)
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    ICitizen citizen = new Citizen(name, age, id);
                    ids.Add(id);
                }

                input = Console.ReadLine();
            }

            string digitsToFind = Console.ReadLine();

            foreach (var fakeId in ids.Where(i => i.EndsWith(digitsToFind)))
            {
                Console.WriteLine(fakeId);
            }
        }
    }
}