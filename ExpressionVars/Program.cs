using System;

namespace ExpressionVars
{
	class Program
	{
		static void Main(string[] args)
		{

			//if (10 < 11)
			//{
			//	Console.WriteLine("10 is less than 11");
			//}
			//if (10 > 11)
			//{
			//	Console.WriteLine("10 is greater than 11");
			//}

			// Print out what the expression actually evaluates to:

			Console.WriteLine(10 < 11);

			bool result = 10 > 11;  // THIS LINE IS KEY TO UNDERSTANDING
			Console.WriteLine(result);


		}
	}
}
