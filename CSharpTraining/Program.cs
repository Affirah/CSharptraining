using System;
using CSharpTraining._0_FirstSteps;

namespace CSharpTraining
{
	public class Program
	{
		private const string Greeting = "Hi";
		private const string Q1 = "Hi! What is your name?";
		private const string Q2 = "How old are you?";
	
		private static string Ans1;
		private static string Ans2;

		public static void Main(string[] args)
		{
		
			//Class is like template
			//BasicCSharpRun is a METHOD that is defined in the CLASS name basicOfCSharp since we used PUBLIC
			//We can directly call the Method in this class as we used STATIC and it can be called using .
			//BasicOfCSharp.BasicCSharpRun();
			//Constants are like class fields

		
			Console.WriteLine(Q1);
			Ans1 = Console.ReadLine();

			Console.WriteLine(Q2);
			Ans2 = Console.ReadLine();

			int age = int.Parse(Ans2);

			if (age > 0 && age < 99)

			{ if (age < 5)

				{
					Console.WriteLine(  Greeting  +   Ans1 + "You have a Free Pass");
				}

				else if (int.Parse(Ans2) < 10)


				{
					Console.WriteLine(Greeting + Ans1 + "10% OFF");
				}

				else
				{
					Console.WriteLine(Greeting + Ans1 + "Enjoy the theme park");
				}
			}
				Console.ReadLine();		
		
		
		}
	}
}
