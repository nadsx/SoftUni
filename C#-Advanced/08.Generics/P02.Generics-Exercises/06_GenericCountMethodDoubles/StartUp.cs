using System;

namespace _06_GenericCountMethodDoubles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < counter; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Values.Add(input);
            }

            double item = double.Parse(Console.ReadLine());

            box.Compare(item);
            int result = box.CountGreater;

            Console.WriteLine(result);
        }
    }
}
