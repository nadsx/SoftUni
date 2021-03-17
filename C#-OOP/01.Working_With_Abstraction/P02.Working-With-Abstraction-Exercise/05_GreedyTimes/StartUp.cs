using System;
using System.Linq;

namespace GreedyTimes
{
    public class StartUp
    {
        public static void Main()
        {
            long bagCapacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Bag bag = new Bag();
            bag.FillBag(safe, bagCapacity);

            Console.WriteLine(bag);
        }
    }
}
