using System;

namespace _05_GenericCountMethodStrings
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

            string item = Console.ReadLine();

            box.Compare(item);
            int result = box.CountGreater;

            Console.WriteLine(result);
        }
    }
}
