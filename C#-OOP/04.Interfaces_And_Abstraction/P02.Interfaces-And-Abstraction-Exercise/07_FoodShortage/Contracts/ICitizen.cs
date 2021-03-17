namespace FoodShortage.Contracts
{
    using System;

    public interface ICitizen
    {
        string Id { get; }

        DateTime Birthday { get; }
    }
}
