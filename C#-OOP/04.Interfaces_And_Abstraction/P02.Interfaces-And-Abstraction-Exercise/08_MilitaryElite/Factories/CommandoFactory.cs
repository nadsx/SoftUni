namespace MilitaryElite.Factories
{
    using Models;

    public class CommandoFactory
    {
        public Commando MakeCommando(string[] args)
        {
            string id = args[1];
            string firstName = args[2];
            string lastName = args[3];
            decimal salary = decimal.Parse(args[4]);
            string corps = args[5];

            Commando commando = new Commando(id, firstName, lastName, salary, corps);

            return commando;
        }
    }
}