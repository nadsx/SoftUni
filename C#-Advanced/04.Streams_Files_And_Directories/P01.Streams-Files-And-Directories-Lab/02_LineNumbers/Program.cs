using System;
using System.IO;

namespace _02_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int counter = 1;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        writer.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
