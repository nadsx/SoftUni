using System;

namespace P03Elevator
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfPeople = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			int courses = (int)Math.Ceiling((double)numberOfPeople / capacity);
			//if(numberOfpeople % capacity != 0)
			//{
			//  courses++;
			//}
			Console.WriteLine(courses);
		}
	}
}
