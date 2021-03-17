using System;

namespace _01_RhombusOfStars
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var rhombusDrawer = new RhombusAsStringDrawer();
            var rhombusAsString = rhombusDrawer.Draw(n);

            Console.WriteLine(rhombusAsString);
        }
    }
}
