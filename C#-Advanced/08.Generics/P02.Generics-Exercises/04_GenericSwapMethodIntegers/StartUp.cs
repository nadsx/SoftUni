using System;
using System.Linq;

namespace _04_GenericSwapMethodIntegers
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < counter; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Values.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
