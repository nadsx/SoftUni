using System;

namespace P05Login
{
	class Program
	{
		static void Main(string[] args)
		{
			string username = Console.ReadLine();
			string password = "";

			for (int i = username.Length - 1; i >= 0; i--)
			{
				password += username[i];
			}

			string currentPassword = Console.ReadLine();

			int invalidPasswordAttempts = 0;

			while (currentPassword != password)
			{
				invalidPasswordAttempts += 1;

				if (invalidPasswordAttempts == 4)
				{
					Console.WriteLine($"User {username} blocked!");
					break;
				}

				Console.WriteLine("Incorrect password. Try again.");
				currentPassword = Console.ReadLine();
			}

			if (invalidPasswordAttempts < 4)
			{
				Console.WriteLine($"User {username} logged in.");
			}
		}
	}
}
