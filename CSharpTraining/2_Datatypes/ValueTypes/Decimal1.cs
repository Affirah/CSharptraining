using System;

namespace CSharpTraining._2_Datatypes.ValueTypes
{
    public class Decimal1
    {
        public static void Run()
        
        {
            decimal price = 19.9978451458744555m;
            decimal price2 = 5.81m; // If the value passed is decimal then the suffix should be M

            decimal Total = price / price2; 

            
            Console.WriteLine(Total);

        }
    }
}
