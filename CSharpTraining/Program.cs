using System;
using CSharpTraining._0_FirstSteps;
using CSharpTraining._2_Datatypes.ValueTypes;

namespace CSharpTraining
{
	public class Program
	{
			public static void Main(string[] args)
        {

            //Bool1.Run();
            //Console.ReadLine();		

            //Char1.Run();
            //Console.ReadLine();

            //Decimal1.Run();
            //Console.ReadLine(); //Result will be 3.4419699046255517211703958692

            //Double1.Run();
            //Console.ReadLine(); // Result will be 3.44196990462555

            //Float1.Run();
            //Console.ReadLine(); // Result will be 3.44197 (All the above 3 have same input but different datatypes results in different precisions in results).

            //int1.Run();
            //Console.ReadLine(); // Result will be a : 20, b : 5, 2147483647

            //Short1.Run();
            //Console.ReadLine(); // Result will be a: 20, b : 5; Maximum value : 32767

            Long1.Run();
            Console.ReadLine(); // Result will be a: 20, b : 5; Maximum value : 9223372036854775807 (Above 3 different datatypes are different in the range and storage)

            
        }
    }
}
