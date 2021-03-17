using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_OrderByAge
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var people = new List<Person>();

			while (input != "End")
			{
				string[] personInfo = input.Split();
				string personName = personInfo[0];
				string personId = personInfo[1];
				int personAge = int.Parse(personInfo[2]);

				var newPerson = new Person()
				{
					Name = personName,
					Id = personId,
					Age = personAge
				};

				people.Add(newPerson);

				input = Console.ReadLine();
			}

			foreach (var person in people.OrderBy(x => x.Age))
			{
				Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
			}
		}
	}
	class Person
	{
		public string Name { get; set; }
		public string Id { get; set; }
		public int Age { get; set; }
	}
}
	

