using System;
using System.Numerics;
using System.Text;

namespace _01_AnonymousDownsite
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int securityKey = int.Parse(Console.ReadLine());

			StringBuilder affectedSites = new StringBuilder();

			decimal totalLoss = 0M;

			for (int i = 0; i < n; i++)
			{
				string[] siteParameters = Console.ReadLine().Split();
				string siteName = siteParameters[0];
				long siteVisits = long.Parse(siteParameters[1]);
				decimal siteCommercialIncomePerVisit = decimal.Parse(siteParameters[2]); 

				affectedSites.AppendLine(siteName); 
				totalLoss += siteCommercialIncomePerVisit * siteVisits; 
			}

			Console.Write(affectedSites); 
			Console.WriteLine($"Total Loss: {totalLoss:F20}"); 
			Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), n)}");
		}
	}
}
