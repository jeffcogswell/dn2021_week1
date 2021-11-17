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
				//int r = 5;  // Question: Does this go away? What is its scope? Play with it and find out
				Console.WriteLine(i);
				//Console.WriteLine(r);
			}

			Console.WriteLine("Let's count by 2's!");
			for (int i = 0; i <= 20; i+=2)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("Let's do a 'while' loop!");
			int j = 0;
			while (j <= 20)
			{
				Console.WriteLine(j);
				if (j < 10)
				{
					j++;
				}
				else
				{
					j += 2;
				}
			}
			Console.WriteLine("We're done with the while loop!");
			Console.WriteLine($"The j variable is now {j}");

			Console.WriteLine("Let's do another while loop");
			j = 0;
			while ( j < 0 )
			{
				Console.WriteLine(j);
				j++;
			}

			Console.WriteLine("Let's do a do-while loop");
			j = 0;
			do
			{
				Console.WriteLine(j);
				j += 2;
			} while (j <= 20);

			Console.WriteLine("And one more do-while loop");
			j = 0;
			do
			{
				Console.WriteLine(j);
				j += 2;
			} while (j < 0);

			Console.WriteLine("All done!");

		}
	}
}
