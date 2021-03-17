using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_StudentAcademy
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			var students = new Dictionary<string, List<double>>();

			for (int i = 0; i < n; i++)
			{
				string currentStudent = Console.ReadLine();
				double currentGrade = double.Parse(Console.ReadLine());

				if (!students.ContainsKey(currentStudent))
				{
					students[currentStudent] = new List<double>();
				}

				students[currentStudent].Add(currentGrade);
			}

			students = students
				.Where(x => x.Value.Average() >= 4.50)
				.OrderByDescending(x => x.Value.Average())
				.ToDictionary(k => k.Key, v => v.Value);

			foreach(var student in students)
			{
				Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
			}		
		}
	}
}
