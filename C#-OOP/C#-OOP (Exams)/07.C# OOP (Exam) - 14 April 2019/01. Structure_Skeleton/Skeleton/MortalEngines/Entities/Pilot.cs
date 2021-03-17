namespace MortalEngines.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MortalEngines.Entities.Contracts;

    public class Pilot : IPilot
    {
        private string name;
        private readonly IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                }

                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if(machine == null)
            {
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.name} - {this.machines.Count} machines");

            foreach(var machine in this.machines)
            {
                sb.AppendLine(machine.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}