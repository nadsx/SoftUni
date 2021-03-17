namespace ViceCity.IO
{
    using System;

    using ViceCity.IO.Contracts;

    class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}