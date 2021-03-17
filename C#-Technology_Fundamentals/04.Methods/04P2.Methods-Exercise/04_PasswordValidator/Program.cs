using System;

namespace _04_PasswordValidator
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			bool isBetweenSixAndTenChars = CheckStringLength(password);
			bool isOnlyLettersAndDigits = CheckStringChars(password);
			bool haveAtLeastTwoDigits = CheckDigitCount(password);

			if (!isBetweenSixAndTenChars)
			{
				Console.WriteLine("Password must be between 6 and 10 characters");
			}

			if (!isOnlyLettersAndDigits)
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}

			if (!haveAtLeastTwoDigits)
			{
				Console.WriteLine("Password must have at least 2 digits");
			}

			if (isBetweenSixAndTenChars && isOnlyLettersAndDigits && haveAtLeastTwoDigits)
			{
				Console.WriteLine("Password is valid");
			}
		}

		private static bool CheckDigitCount(string password)
		{
			int counter = 0;

			for (int i = 0; i < password.Length; i++)
			{
				if (char.IsDigit(password[i]))
				{
					counter++;
				}
			}

			return counter >= 2 ? true : false;
		}

		private static bool CheckStringChars(string password)
		{
			for (int i = 0; i < password.Length; i++)
			{
				if (!char.IsLetterOrDigit(password[i]))
				{
					return false;
				}
			}

			return true;
		}

		private static bool CheckStringLength(string password)
		{
			return password.Length >= 6 && password.Length <= 10 ? true : false;
		}
	}
}
