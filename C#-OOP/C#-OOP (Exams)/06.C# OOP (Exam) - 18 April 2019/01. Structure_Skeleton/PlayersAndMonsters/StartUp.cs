namespace PlayersAndMonsters
{
    using Core;
    using Core.Contracts;
    using IO;
    using IO.Contracts;

    public class StartUp
    {
        public static void Main()
        {
            IWriter writer = new Writer();
            IReader reader = new Reader();

            IManagerController managerController = new ManagerController();
            ICommandInterpreter commandInterpreter = new CommandInterpreter(managerController);
            IEngine engine = new Engine(commandInterpreter, reader, writer);

            engine.Run();
        }
    }
}