using System;

namespace LoopDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			int q = 10;
			Console.WriteLine(q);
			q++; // identical to q = q + 1
			q += 5;   // Same as q = q + 5 -- it adds 5 to q
			Console.WriteLine(q);


			Console.WriteLine("Before the loop");
			Console.WriteLine("Getting ready!");

			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("Let's count down starting with 10 and ending with 1 (inclusive for both).");
			for (int i = 10; i > 0; i--)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("All done!");
		}
	}
}
