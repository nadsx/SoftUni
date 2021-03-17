using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_AdvertisementMessage
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfMessages = int.Parse(Console.ReadLine());
			List<string> messages = GenerateRandomMessage(numberOfMessages);

			Console.WriteLine(string.Join(Environment.NewLine, messages));
		}

		static List<string> GenerateRandomMessage(int numberOfMessages)
		{
			var phrases = new string[]
			{
				"Excellent product.",
				"Such a great product.",
				"I always use that product.",
				"Best product of its category.",
				"Exceptional product.",
				"I can’t live without this product."
			};

			var events = new string[]
			{
				"Now I feel good.",
				"I have succeeded with this product.",
				"Makes miracles. I am happy of the results!",
				"I cannot believe but now I feel awesome.",
				"Try it yourself, I am very satisfied.",
				"I feel great!"
			};

			var authors = new string[]
			{"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

			var cities = new string[]
			{"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

			var random = new Random();
			var result = new List<string>();

			for (int i = 0; i < numberOfMessages; i++)
			{
				var randomPhrase = phrases[random.Next(phrases.Length)];
				var randomEvent = events[random.Next(events.Length)];
				var randomAuthor = authors[random.Next(authors.Length)];
				var randomCity = cities[random.Next(cities.Length)];

				result.Add($"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}");
			}

			return result;
		}
	}
}
	

	


