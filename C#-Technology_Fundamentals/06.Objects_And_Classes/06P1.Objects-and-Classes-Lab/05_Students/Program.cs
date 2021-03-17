using System;
using System.Collections.Generic;

namespace _05_Students
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

				var student = new Student()
				{
					FirstName = firstName,
					LastName = lastName,
					Age = age,
					City = city
				};

				students.Add(student);

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
