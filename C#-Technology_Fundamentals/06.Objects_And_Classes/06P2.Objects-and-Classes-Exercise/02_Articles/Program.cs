using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Articles
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ");
			int n = int.Parse(Console.ReadLine());

			var article = new Article(input[0], input[1], input[2]);

			for (int i = 0; i < n; i++)
			{
				string[] tokens = Console.ReadLine().Split(": ");
				string command = tokens[0];

				switch (command)
				{
					case "Edit":
						article.Edit(tokens[1]);
						break;
					case "ChangeAuthor":
						article.ChangeAuthor(tokens[1]);
						break;
					case "Rename":
						article.Rename(tokens[1]);
						break;
				}
			}

			Console.WriteLine(article);
		}

		class Article
		{
			public string Title { get; set; }
			public string Content { get; set; }
			public string Author { get; set; }

			public Article(string title, string content, string author)
			{
				Title = title;
				Content = content;
				Author = author;
			}

			public void Edit(string newContent)
			{
				Content = newContent;
			}

			public void ChangeAuthor(string newAuthor)
			{
				Author = newAuthor;
			}

			public void Rename(string newTitle)
			{
				Title = newTitle;
			}

			public override string ToString()
			{
				return $"{Title} - {Content}: {Author}";
			}
		}
	}
}
	

