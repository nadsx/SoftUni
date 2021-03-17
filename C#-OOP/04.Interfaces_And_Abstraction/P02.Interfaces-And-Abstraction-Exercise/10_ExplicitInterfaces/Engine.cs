namespace ExplicitInterfaces
{
    using System;
    using System.Linq;

    public class Engine
    {
        private readonly PersonFactory personFactory;

        public Engine()
        {
            this.personFactory = new PersonFactory();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] citizenInfo = input.Split().ToArray();

                IPerson person = this.personFactory.MakeCitizen(citizenInfo);
                IResident resident = this.personFactory.MakeCitizen(citizenInfo);

                Console.WriteLine(resident.GetName());
                Console.WriteLine(person.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
