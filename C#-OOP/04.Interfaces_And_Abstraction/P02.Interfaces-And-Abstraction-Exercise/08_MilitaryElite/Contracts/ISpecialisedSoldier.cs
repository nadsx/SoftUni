namespace MilitaryElite.Contracts
{
    using Enums;

    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
