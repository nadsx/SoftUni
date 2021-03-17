using System;
using System.Collections.Generic;

namespace _04_Songs
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfSongs = int.Parse(Console.ReadLine());

			List<Song> songs = new List<Song>();

			for (int i = 0; i < numberOfSongs; i++)
			{
				string[] data = Console.ReadLine().Split("_");

				string type = data[0];
				string name = data[1];
				string time = data[2];

				var song = new Song();

				song.TypeList = type;
				song.Name = name;
				song.Time = time;

				songs.Add(song);
			}

			string typeList = Console.ReadLine();

			if (typeList == "all")
			{
				foreach (var song in songs)
				{
					Console.WriteLine(song.Name);
				}
			}
			else
			{
				foreach (var song in songs)
				{
					if (song.TypeList == typeList)
					{
						Console.WriteLine(song.Name);
					}
				}
			}

		}
	}
	class Song
	{
		public string TypeList { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
	}
}
