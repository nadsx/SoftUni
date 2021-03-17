using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AverageStudentGrades
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var studentsGrades = new Dictionary<string, List<double>>();

			for (int i = 0; i < n; i++)
			{
				string[] studentInfo = Console.ReadLine()
					.Split(' ', StringSplitOptions.RemoveEmptyEntries)
					.ToArray();
				string name = studentInfo[0];
				double grade = double.Parse(studentInfo[1]);

				if (!studentsGrades.ContainsKey(name))
				{
					studentsGrades[name] = new List<double>();
				}

				studentsGrades[name].Add(grade);
			}

			foreach (var studentGrade in studentsGrades)
			{
				Console.Write($"{studentGrade.Key} -> ");

				foreach (var grade in studentGrade.Value)
				{
					Console.Write($"{grade:f2} ");
				}

				Console.WriteLine($"(avg: {studentGrade.Value.Average():f2})");
			}
		}
	}
}
