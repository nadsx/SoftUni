namespace MXGP
{
    using System;
    using System.Linq;

    using MXGP.Core;

    public class StartUp
    {
        public static void Main()
        {
            ChampionshipController controller = new ChampionshipController();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] commandArgs = line.Split().ToArray();
                string result = string.Empty;

                try
                {
                    switch (commandArgs[0])
                    {
                        case "CreateRider":
                            result += controller.CreateRider(commandArgs[1]);
                            break;

                        case "CreateMotorcycle":
                            result += controller.CreateMotorcycle(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                            break;

                        case "AddMotorcycleToRider":
                            result += controller.AddMotorcycleToRider(commandArgs[1], commandArgs[2]);
                            break;

                        case "AddRiderToRace":
                            result += controller.AddRiderToRace(commandArgs[1], commandArgs[2]);
                            break;

                        case "CreateRace":
                            result += controller.CreateRace(commandArgs[1], int.Parse(commandArgs[2]));
                            break;

                        case "StartRace":
                            result += controller.StartRace(commandArgs[1]);
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                line = Console.ReadLine();
            }
        }
    }
}