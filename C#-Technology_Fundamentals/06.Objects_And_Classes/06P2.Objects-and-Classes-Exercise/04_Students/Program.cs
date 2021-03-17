using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Students
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Student> students = new List<Student>();

			for (int i = 0; i < n; i++)
			{
				string[] tokens = Console.ReadLine().Split();

				Student student = new Student(tokens[0], tokens[1], double.Parse(tokens[2]));

				students.Add(student);
			}

			Console.WriteLine(string.Join(Environment.NewLine, students
				.OrderByDescending(x => x.Grade)));
		}
	}
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Grade { get; set; }

		public Student(string firstName, string lastName, double grade)
		{
			FirstName = firstName;
			LastName = lastName;
			Grade = grade;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName}: {Grade:f2}";
		}
	}
}
	

