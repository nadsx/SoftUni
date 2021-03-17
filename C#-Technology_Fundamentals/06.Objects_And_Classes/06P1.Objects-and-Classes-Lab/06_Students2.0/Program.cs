using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Students2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();

			string inputData = Console.ReadLine();

			while (inputData != "end")
			{
				string[] tokens = inputData.Split();

				string firstName = tokens[0];
				string lastName = tokens[1];
				int age = int.Parse(tokens[2]);
				string city = tokens[3];

				var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

				if (student == null)
				{
					students.Add(new Student()
					{
						FirstName = firstName,
						LastName = lastName,
						Age = age,
						City = city
					});
				}
				else
				{
					student.FirstName = firstName;
					student.LastName = lastName;
					student.Age = age;
					student.City = city;
				}

				inputData = Console.ReadLine();
			}

			string filterCity = Console.ReadLine();

			foreach (var student in students)
			{
				if (student.City == filterCity)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}
		}
	}
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string City { get; set; }
	}
}


