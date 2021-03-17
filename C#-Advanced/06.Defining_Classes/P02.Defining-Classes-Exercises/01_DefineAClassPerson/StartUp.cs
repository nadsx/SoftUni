using System;

namespace DefiningClasses
{
	public class StartUp
	{
		static void Main()
		{
			Person person = new Person();
			person.Name = "Pesho";
			person.Age = 20;

           //Console.WriteLine($"Name:{person.Name} Age:{person.Age}");
		}
	}
}
