using System;

namespace _03_StudentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            StudentSystem studentSystem = new StudentSystem();
            studentSystem.ParseCommands();
        }
    }
}
