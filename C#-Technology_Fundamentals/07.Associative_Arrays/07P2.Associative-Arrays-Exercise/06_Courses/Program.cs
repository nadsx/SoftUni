using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Courses
{
	class Program
	{
		static void Main(string[] args)
		{
			var courses = new Dictionary<string, List<string>>();

			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] tokens = input.Split(" : ").ToArray();
				string currentCourse = tokens[0];
				string currentStudent = tokens[1];

				if (!courses.ContainsKey(currentCourse))
				{
					courses[currentCourse] = new List<string>();
				}

				courses[currentCourse].Add(currentStudent);

				input = Console.ReadLine();
			}

			courses = courses
				.OrderByDescending(x => x.Value.Count)
				.ToDictionary(k => k.Key, v => v.Value);

			foreach(var course in courses)
			{
				Console.WriteLine($"{course.Key}: {course.Value.Count}");

				Console.WriteLine(string.Join("\n", course.Value.Select(x => $"-- {x}").OrderBy(x => x)));
			}
		}
	}
}
