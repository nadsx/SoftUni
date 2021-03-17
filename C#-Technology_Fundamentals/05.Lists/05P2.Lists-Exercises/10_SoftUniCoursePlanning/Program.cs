using System;
using System.Linq;

namespace _10_SoftUniCoursePlanning
{
	class Program
	{
		static void Main(string[] args)
		{
			var lessonsList = Console.ReadLine()
				.Split(", ", StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			var input = Console.ReadLine();

			while (input != "course start")
			{
				var tokens = input
					.Split(':', StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				var command = tokens[0];
				var lesson = tokens[1];

				switch (command)
				{
					case "Add":
						if (!lessonsList.Contains(lesson))
						{
							lessonsList.Add(lesson);
						}
						break;
					case "Insert":
						var index = int.Parse(tokens[2]);

						if (!lessonsList.Contains(lesson) && (0 <= index && index < lessonsList.Count))
						{
							lessonsList.Insert(index, lesson);
						}
						break;
					case "Remove":
						lessonsList.Remove(lesson);
						lessonsList.Remove($"{lesson}-Exercise");
						break;
					case "Swap":
						var firstLessonTitle = tokens[1];
						var secondLessonTitle = tokens[2];

						var indexOfFirstLesson = lessonsList.IndexOf(firstLessonTitle);
						var indexOfSecondLesson = lessonsList.IndexOf(secondLessonTitle);

						if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
						{
							lessonsList[indexOfFirstLesson] = secondLessonTitle;
							lessonsList[indexOfSecondLesson] = firstLessonTitle;

							if (indexOfFirstLesson + 1 < lessonsList.Count &&
								lessonsList[indexOfFirstLesson + 1] == $"{firstLessonTitle}-Exercise")
							{
								lessonsList.RemoveAt(indexOfFirstLesson + 1);
								indexOfFirstLesson = lessonsList.IndexOf(firstLessonTitle);
								lessonsList.Insert(indexOfFirstLesson + 1, $"{firstLessonTitle}-Exercise");
							}
							else if (indexOfSecondLesson + 1 < lessonsList.Count &&
								lessonsList[indexOfSecondLesson + 1] == $"{secondLessonTitle}-Exercise")
							{
								lessonsList.RemoveAt(indexOfSecondLesson + 1);
								indexOfSecondLesson = lessonsList.IndexOf(secondLessonTitle);
								lessonsList.Insert(indexOfSecondLesson + 1, $"{secondLessonTitle}-Exercise");
							}
						}
						break;
					case "Exercise":
						index = lessonsList.IndexOf(lesson);

						if (lessonsList.Contains(lesson) &&
							!lessonsList.Contains($"{lesson}-Exercise"))
						{
							lessonsList.Insert(index + 1, $"{lesson}-Exercise");
						}
						else if (!lessonsList.Contains(lesson))
						{
							lessonsList.Add(lesson);
							lessonsList.Add($"{lesson}-Exercise");
						}
						break;
				}

				input = Console.ReadLine();
			}

			for (int i = 0; i < lessonsList.Count; i++)
			{
				Console.WriteLine($"{i + 1}.{lessonsList[i]}");
			}
		}
	}
}
