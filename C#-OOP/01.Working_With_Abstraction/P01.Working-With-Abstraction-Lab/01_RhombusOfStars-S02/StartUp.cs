using System;

namespace _01_RhombusOfStars_S02
{
    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 1; i <= size; i++)
            {
                PrintRow(i, size);
            }

            for (int i = size - 1; i > 0; i--)
            {
                PrintRow(i, size);
            }
        }

        private static void PrintRow(int starCount, int totalStars)
        {
            int leadingSpaces = totalStars - starCount;
            Console.Write(new string(' ', leadingSpaces));

            for (int i = 0; i < starCount; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
