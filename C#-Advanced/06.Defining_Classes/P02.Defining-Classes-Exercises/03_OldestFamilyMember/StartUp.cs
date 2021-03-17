using System;
using System.Linq;

namespace DefiningClasses
{
	public class StartUp
	{
		public static void Main()
		{
			int familyMembersCount = int.Parse(Console.ReadLine());
			Family family = new Family();

			for (int i = 0; i < familyMembersCount; i++)
			{
				string[] memberData = Console.ReadLine().Split().ToArray();

				string memberName = memberData[0];
				int memberAge = int.Parse(memberData[1]);

				Person member = new Person(memberName, memberAge);

				family.AddMember(member);
			}

			Person oldestFamilyMember = family.GetOldestMember();

			Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
		}
	}
}
