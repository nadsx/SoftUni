namespace ViceCity.Core
{
    using System;
    using System.Linq;

    using ViceCity.Core.Contracts;
    using ViceCity.IO.Contracts;
    using ViceCity.IO;

    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private Controller controller;

        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
            this.controller = new Controller();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = reader.ReadLine().Split().ToArray();

                string result = string.Empty;

                if (input[0] == "Exit")
                {
                    Environment.Exit(0);
                }

                try
                {
                    if (input[0] == "AddPlayer")
                    {
                        result += this.controller.AddPlayer(input[1]);
                    }
                    else if (input[0] == "AddGun")
                    {
                        result += this.controller.AddGun(input[1], input[2]);
                    }
                    else if (input[0] == "AddGunToPlayer")
                    {
                        result += this.controller.AddGunToPlayer(input[1]);
                    }
                    else if (input[0] == "Fight")
                    {
                        result += this.controller.Fight();
                    }

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
        }
    }
}