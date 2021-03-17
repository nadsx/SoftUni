using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_DayOfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] weekDays =
	        {
	        	"Monday",
	        	"Tuesday",
	        	"Wednesday",
	        	"Thursday",
	        	"Friday",
	        	"Saturday",
	        	"Sunday"
	        };

			int day = int.Parse(Console.ReadLine());

			if (day < 1 || day > 7)
			{
				Console.WriteLine("Invalid day!");
			}
			else
			{
				Console.WriteLine(weekDays[day - 1]);
			}			
		}	  
	}		  
}			  