using System;

namespace P09PadawanEquipment
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			int studentsCount = int.Parse(Console.ReadLine());
			double sabersPrice = double.Parse(Console.ReadLine());
			double robesPrice = double.Parse(Console.ReadLine());
			double beltsPrice = double.Parse(Console.ReadLine());

			var spendedMoney = sabersPrice * Math.Ceiling(studentsCount * 1.1) +
				robesPrice * studentsCount + beltsPrice * (studentsCount - (studentsCount / 6));

			if(spendedMoney <= money)
			{
				Console.WriteLine($"The money is enough - it would cost {spendedMoney:f2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {spendedMoney - money:f2}lv more.");
			}
		}
	}
}
