using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstNumbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondNumbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> mergedList = new List<int>();

			int minListCount = Math.Min(firstNumbersList.Count, secondNumbersList.Count);

			for (int i = 0; i < minListCount; i++)
			{
				mergedList.Add(firstNumbersList[i]);
				mergedList.Add(secondNumbersList[i]);
			}

			List<int> biggerList = minListCount == firstNumbersList.Count ?
				secondNumbersList : firstNumbersList;

			for (int i = minListCount; i < biggerList.Count; i++)
			{
				mergedList.Add(biggerList[i]);
			}

			Console.WriteLine(string.Join(" ", mergedList));
		}
	}
}
