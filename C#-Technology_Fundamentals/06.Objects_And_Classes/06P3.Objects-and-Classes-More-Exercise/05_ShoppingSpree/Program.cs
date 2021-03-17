using System;
using System.Collections.Generic;

namespace _05_ShoppingSpree
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] personTokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
			string[] productTokens = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

			List<Person> people = new List<Person>();
			List<Product> products = new List<Product>();

			for (int i = 0; i < personTokens.Length; i++)
			{
				string[] tokens = personTokens[i].Split("=");
				Person person = new Person(tokens);
				people.Add(person);
			}

			for (int i = 0; i < productTokens.Length; i++)
			{
				string[] tokens = productTokens[i].Split("=");
				Product product = new Product(tokens);
				products.Add(product);
			}

			string input = Console.ReadLine();

			while (input != "END")
			{
				string[] tokens = input.Split();
				string buyerName = tokens[0];
				string buyingProduct = tokens[1];

				people.Find(x => x.PersonName == buyerName).BuyProduct(products.Find(x => x.ProductName == buyingProduct));

				input = Console.ReadLine();
			}

			foreach (var person in people)
			{
				if (person.BagOfProducts.Count > 0)
				{
					Console.WriteLine($"{person.PersonName} - {string.Join(", ", person.BagOfProducts)}");
				}
				else
				{
					Console.WriteLine($"{person.PersonName} - Nothing bought");
				}
			}
		}
		class Person
		{
			public string PersonName { get; set; }
			public decimal Money { get; set; }
			public List<string> BagOfProducts { get; set; } = new List<string>();

			public Person(string[] personTokens)
			{
				PersonName = personTokens[0];
				Money = decimal.Parse(personTokens[1]);
			}

			public void BuyProduct(Product productToBuy)
			{
				if (Money >= productToBuy.Cost)
				{
					Money -= productToBuy.Cost;
					BagOfProducts.Add(productToBuy.ProductName);
					Console.WriteLine($"{PersonName} bought {productToBuy.ProductName}");
				}
				else
				{
					Console.WriteLine($"{PersonName} can't afford {productToBuy.ProductName}");
				}
			}
		}
		class Product
		{
			public string ProductName { get; set; }
			public decimal Cost { get; set; }

			public Product(string[] productTokens)
			{
				ProductName = productTokens[0];
				Cost = decimal.Parse(productTokens[1]);
			}
		}
	}
}

