using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MixedUpLists
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> firstNumbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> secondNumbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

			List<int> maxList = new List<int>();

			if(firstNumbersList.Count > secondNumbersList.Count)
			{
				maxList = firstNumbersList;
			}
			else
			{
				maxList = secondNumbersList;
				maxList.Reverse();
			}

			List<int> rangeList = new List<int>();
			rangeList = maxList.GetRange(maxList.Count - 2, 2); 
			rangeList.Sort();

			if(firstNumbersList.Count > secondNumbersList.Count)
			{
				firstNumbersList.RemoveRange(firstNumbersList.Count - 2, 2);
				secondNumbersList.Reverse();
			}
			else
			{
				secondNumbersList.RemoveRange(secondNumbersList.Count - 2, 2);
				secondNumbersList.Reverse();
			}

			List<int> mixedList = new List<int>();

			for (int i = 0; i < firstNumbersList.Count; i++)
			{
				mixedList.Add(firstNumbersList[i]);
				mixedList.Add(secondNumbersList[i]);
			}

			List<int> finalList = mixedList.FindAll(x => x > rangeList[0] && x < rangeList[1]);
			finalList.Sort();

			Console.WriteLine(string.Join(" ", finalList));
		}
	}
}
