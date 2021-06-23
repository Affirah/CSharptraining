using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//Variable declaration
			string value;

			//Assign Variable
			value = "Good Day";

			//ReadLine
			Console.WriteLine("AJ " + value);
			Console.WriteLine(Sum(2, 3));

			//PrintLine
			Console.ReadLine();
		}
		public static int Sum(int value1, int value2)
		{
			return value1 + value2;
		}
	}
}
