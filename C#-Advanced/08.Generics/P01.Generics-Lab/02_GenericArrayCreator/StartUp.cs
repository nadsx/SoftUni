using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Didi");
            int[] integers = ArrayCreator.Create(10, 99);

            Console.WriteLine(string.Join(" ", strings));
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
