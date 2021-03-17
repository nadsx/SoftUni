using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OldestFamilyMember
{
	class Program
	{
		static void Main(string[] args)
		{
			int peopleCount = int.Parse(Console.ReadLine());
			Family family = new Family();

			for (int i = 0; i < peopleCount; i++)
			{
				string[] tokens = Console.ReadLine().Split();

				family.AddMember(new Person(tokens));
			}

			Person oldestPerson = family.GetOldestMember();

			Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
		}
	}
	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person(string[] personInfo)
		{
			Name = personInfo[0];
			Age = int.Parse(personInfo[1]);
		}
	}
	class Family
	{
		public List<Person> FamilyMembers { get; set; } = new List<Person>();

		public void AddMember(Person member)
		{
			FamilyMembers.Add(member);
		}

		public Person GetOldestMember()
		{
			return FamilyMembers.OrderByDescending(x => x.Age).First();
		}
	}
}
	

