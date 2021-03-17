namespace MilitaryElite.Factories
{
    using Models;

    public class RepairFactory
    {
        public Repair MakeRepair(string partName, int hoursWorked)
        {
            Repair repair = new Repair(partName, hoursWorked);

            return repair;
        }
    }
}