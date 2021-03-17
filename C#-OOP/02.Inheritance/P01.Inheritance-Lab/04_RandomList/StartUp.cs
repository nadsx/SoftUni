using System;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList randomList = new RandomList();

            for (int i = 1; i <= 20; i++)
            {
                randomList.List.Add(i.ToString());
            }

            Console.WriteLine(randomList.RandomString());
        }
    }
}
