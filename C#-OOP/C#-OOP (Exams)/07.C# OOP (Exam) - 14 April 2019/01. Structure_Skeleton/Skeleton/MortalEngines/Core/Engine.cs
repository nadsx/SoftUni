namespace MortalEngines.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using MortalEngines.Core.Contracts;

    public class Engine : IEngine
    {
        private readonly IMachinesManager machinesManager;

        public Engine()
        {
            this.machinesManager = new MachinesManager();
        }

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string result = string.Empty;
                string commandName = input[0];

                if (commandName == "Quit")
                {
                    break;
                }

                try
                {
                    if(commandName == "AggressiveMode")
                    {
                        result = this.machinesManager.ToggleFighterAggressiveMode(input[1]);
                    }
                    else if(commandName == "DefenseMode")
                    {
                        result = this.machinesManager.ToggleTankDefenseMode(input[1]);
                    }
                    else if (commandName == "Engage")
                    {
                        result = this.machinesManager.EngageMachine(input[1], input[2]);
                    }
                    else if (commandName == "Attack")
                    {
                        result = this.machinesManager.AttackMachines(input[1], input[2]);
                    }
                    else
                    {
                        string[] args = input.Skip(1).ToArray();

                        MethodInfo method = typeof(MachinesManager)
                            .GetMethod(commandName);

                        List<object> requiredParams = new List<object>();

                        foreach (var arg in args)
                        {
                            if (double.TryParse(arg, out double parsedParam))
                            {
                                requiredParams.Add(parsedParam);

                                continue;
                            }

                            requiredParams.Add(arg);
                        }

                        result = (string)method.Invoke(this.machinesManager, requiredParams.ToArray());                     
                    }

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}