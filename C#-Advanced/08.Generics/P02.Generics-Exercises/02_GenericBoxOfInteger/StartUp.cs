using System;

namespace _02_GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);

                Console.WriteLine(box);
            }
        }
    }
}
