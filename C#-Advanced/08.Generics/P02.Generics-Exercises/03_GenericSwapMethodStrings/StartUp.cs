using System;
using System.Linq;

namespace _03_GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();

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
