namespace ViceCity
{
    using ViceCity.Core;
    using ViceCity.Core.Contracts;

    public class StartUp
    {
        IEngine engine;

        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}