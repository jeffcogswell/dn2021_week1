using System;

namespace LoopDemo2
{
	class Program
	{
		static void Main(string[] args)
		{

			// While loop with a break

			int i = 0;

			while (i <= 20)
			{
				Console.WriteLine(i);

				if (i == 10)
				{
					Console.WriteLine("Quitting early!");
					break;
				}

				i++;
			}

			Console.WriteLine("All done!");
			Console.WriteLine("Let's do it again!");

			i = 0;

			while (true)
			{
				Console.WriteLine(i);

				if (i == 10)
				{
					Console.WriteLine("Getting out!");
					break;
				}

				i++;
			}

			Console.WriteLine("All done!");

			//Console.WriteLine("Maybe this is better?");
			//bool keepGoing = true;
			//while (keepGoing == true)
			//{
			//	Console.WriteLine("We're going again!");
			//	Console.WriteLine(DateTime.Now);

			//	Console.WriteLine("Would you like to go again?");
			//	string entry = Console.ReadLine();
			//	if (entry == "N")
			//	{
			//		keepGoing = false;
			//	}
			//}

			Console.WriteLine("Now we can ask the user whether to quit. But let's try another way.");
			string entry = "";
			do
			{
				Console.WriteLine("We're going again!");
				Console.WriteLine(DateTime.Now);

				Console.WriteLine("Would you like to go again?");
				entry = Console.ReadLine();
			} while ( entry != "N" );

			Console.WriteLine("Now let's try out 'continue'");

			for (int j = 0; j <= 20; j++)
			{
				Console.WriteLine(j);
				if (j % 2 == 1)
				{
					continue;
				}
				// At this point, j is even, so let's do the even stuff
				Console.WriteLine($"j is even. j times itself is {j * 2}");
			}

			Console.WriteLine("One more time, but without continue");
			for (int j = 0; j <= 20; j++)
			{
				Console.WriteLine(j);
				if (j % 2 == 0)
				{
					Console.WriteLine($"j is even. j times itself is {j * 2}");
				}
			}
		}
	}
}
