using System;
using System.IO;

namespace _01_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {         
            using(var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int counter = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}
