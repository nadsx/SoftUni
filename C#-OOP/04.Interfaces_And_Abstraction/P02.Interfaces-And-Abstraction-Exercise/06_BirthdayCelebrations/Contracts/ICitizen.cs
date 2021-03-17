namespace BirthdayCelebrations.Contracts
{
    using System;

    public interface ICitizen
    {
        string Name { get; }

        int Age { get; }

        string Id { get; }

        DateTime Birthday { get; }
    }
}