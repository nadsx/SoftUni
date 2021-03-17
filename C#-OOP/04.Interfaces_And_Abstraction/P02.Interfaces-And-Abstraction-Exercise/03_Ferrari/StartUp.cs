namespace FerrariInfo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            ICar ferrari = new Ferrari(name);
            
            Console.WriteLine(ferrari.ToString());
        }
    }
}