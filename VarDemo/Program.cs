using System;

namespace VarDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello \"World!");
			//Console.WriteLine("This is a second line of text");

			string message = "Hello world";
			Console.WriteLine(message);

			int AppleCount = 25;
			Console.WriteLine(AppleCount);
			Console.WriteLine(AppleCount + 1);
			Console.WriteLine(AppleCount);

			AppleCount = AppleCount + 10;
			Console.WriteLine(AppleCount);

			AppleCount = AppleCount * 2;
			Console.WriteLine(AppleCount);

			double x = 3.14;
			Console.WriteLine(x);

			// float y = 6.28f; We don't use floats often in this course

			double z = 20.0 / 3.0;
			Console.WriteLine(z);

			// We don't use floating point or double for money and financial programs
			// Instead we use decimal type.
			decimal balance = 100.2512345m;
			Console.WriteLine(balance);

			bool atLunch = false;
			Console.WriteLine(atLunch);
			atLunch = true;
			Console.WriteLine(atLunch);

			// "null" - as in no shopping list at all, so we can't write on it.
			string test = null;
			Console.WriteLine(test);

			// Practice noun dot verb
			Console.WriteLine(message.Length);
			Console.WriteLine(message.ToUpper()); // strings are immutable
			Console.WriteLine(message);
			message = "something else";
			Console.WriteLine(message);

			// More noun dot verb. This time with types themselves
			string nums = "37";
			int amount = int.Parse(nums);
			Console.WriteLine(amount * 2);

			Console.WriteLine("\nEnter an integer.");
			string entry = Console.ReadLine();
			int value = int.Parse(entry);
			Console.WriteLine(value * 20);
		}
	}
}
