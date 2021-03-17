namespace CommandPattern.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using CommandPattern.Core.Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public string Read(string inputLine)
        {
            string[] cmdTokens = inputLine.Split().ToArray();
            string commandName = cmdTokens[0] + COMMAND_POSTFIX;
            string[] commandArguments = cmdTokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type[] types = assembly.GetTypes();
            Type typeToCreate = types.FirstOrDefault(t => t.Name == commandName);

            if (typeToCreate == null)
            {
                throw new InvalidOperationException("Invalid command type!");
            }

            //Object instance = Activator.CreateInstance(typeToCreate);
            //ICommand command = (ICommand)instance;
            ICommand commandInstance = Activator.CreateInstance(typeToCreate) as ICommand;

            //if (commandInstance == null)
            //{
            //    throw new InvalidOperationException("Invalid command type!");
            //}

            string result = commandInstance.Execute(commandArguments);

            return result;
        }
    }
}