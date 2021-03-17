using System;
using System.Linq;

namespace _08_Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split().ToArray();
            string[] personBeerInfo = Console.ReadLine().Split().ToArray();
            string[] bankInfo = Console.ReadLine().Split().ToArray();

            string personFullName = personInfo[0] + " " + personInfo[1];
            string personAddress = personInfo[2];
            string personTown = string.Join(" ", personInfo.Skip(3));

            string personBeerName = personBeerInfo[0];
            int amountOfBeer = int.Parse(personBeerInfo[1]);
            bool conditionOfPerson = personBeerInfo[2] == "drunk" ? true : false;

            string personName = bankInfo[0];
            double accountBalance = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            Threeuple<string, string, string> personThreeuple = new Threeuple<string, string, string>(personFullName, personAddress, personTown);
            Threeuple<string, int, bool> personBeerThreeuple = new Threeuple<string, int, bool>(personBeerName, amountOfBeer, conditionOfPerson);
            Threeuple<string, double, string> bankThreeuple = new Threeuple<string, double, string>(personName, accountBalance, bankName);

            Console.WriteLine(personThreeuple);
            Console.WriteLine(personBeerThreeuple);
            Console.WriteLine(bankThreeuple);
        }
    }
}
