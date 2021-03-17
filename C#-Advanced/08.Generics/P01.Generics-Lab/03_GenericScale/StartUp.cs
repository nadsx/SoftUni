using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main()
        {
            var scale1 = new EqualityScale<int>(7, 8);
            Console.WriteLine(scale1.AreEqual());

            var scale2 = new EqualityScale<int>(8, 8);
            Console.WriteLine(scale2.AreEqual());
        }
    }
}
