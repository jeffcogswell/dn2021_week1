using System;

namespace NumAnalyze2
{
	class Program
	{

		static bool IsOddUnder60(int num)
		{
			// Checking the expression for either true or false
			if (num % 2 == 1 && num < 60)
			{
				// When the expression comes back true, return true
				return true;
			}
			else
			{
				// When the expression comes back false, return false
				return false;
			}
		}

		static bool IsOddOver60(int num)
		{
			// Really, we're just returning exactly what we got back
			// from the expression. So why not just return exactly
			// what we got back?
			return num % 2 == 1 && num > 60;
		}

		static void Main(string[] args)
		{

			//Console.WriteLine(10 > 11);

			int x = 61;
			if (IsOddUnder60(x) == true)
			{
				Console.WriteLine($"{x} is odd under 60.");
			}
			else if (IsOddOver60(x) == true)
			{
				Console.WriteLine($"{x} is odd over 60.");
			}
		}
	}
}
