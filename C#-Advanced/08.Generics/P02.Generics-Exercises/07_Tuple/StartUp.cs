using System;
using System.Linq;

namespace _07_Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split().ToArray();
            string[] personBeerInfo = Console.ReadLine().Split().ToArray();
            string[] numbersInfo = Console.ReadLine().Split().ToArray();

            string personFullName = personInfo[0] + " " + personInfo[1];
            string personTown = personInfo[2];

            string personBeerName = personBeerInfo[0];
            int amountOfBeer = int.Parse(personBeerInfo[1]);

            int myInteger = int.Parse(numbersInfo[0]);
            double myDouble = double.Parse(numbersInfo[1]);

            Tuple<string, string> personTuple = new Tuple<string, string>(personFullName, personTown);
            Tuple<string, int> personBeerTuple = new Tuple<string, int>(personBeerName, amountOfBeer);
            Tuple<int, double> numbersTuple = new Tuple<int, double>(myInteger, myDouble);

            Console.WriteLine(personTuple);
            Console.WriteLine(personBeerTuple);
            Console.WriteLine(numbersTuple);
        }
    }
}
