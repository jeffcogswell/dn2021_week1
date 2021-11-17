using System;

namespace NumAnalyze1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("First text");
			//Console.Write("Second text");
			//Console.Write("Third text");
			//Console.WriteLine("\nFourth text");


			Console.Write("Please enter a number between 1 and 100: ");
			string entry = Console.ReadLine();
			int num = int.Parse(entry);
			Console.WriteLine($"You entered:\t{entry}.");

			if (num % 2 == 1 && num < 60)
			{
				Console.WriteLine($"{num} is odd and is less than 60.");
			}
			else if (num % 2 == 0 && num >= 2 && num <= 24)
			{
				Console.WriteLine($"{num} is even and less than 25.");
			}
			else if (num % 2 == 0 && num >= 26 && num <= 60)
			{
				Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
			}
			else if (num % 2 == 0 && num > 60)
			{
				Console.WriteLine($"{num} is even and greater than 60.");
			}
			else if (num % 2 == 1 && num > 60)
			{
				Console.WriteLine($"{num} is odd and greater than 60.");
			}


			// Version 2

			Console.WriteLine("Here's version 2.");

			if (num % 2 == 1)
			{
				if (num < 60)
				{
					Console.WriteLine($"{num} is odd and less than 60.");
				}
				else
				{
					Console.WriteLine($"{num} is odd and greater than 60.");
				}
			}
			else
			{
				if (num >=2 && num <= 24)
				{
					Console.WriteLine($"{num} is even and less than 25.");
				}
				else if (num >= 26 && num <= 60)
				{
					Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
				}
				else
				{
					Console.WriteLine($"{num} is even and greater than 60.");
				}
			}

		}
	}
}
