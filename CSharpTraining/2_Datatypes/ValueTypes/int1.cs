using System;

namespace CSharpTraining._2_Datatypes.ValueTypes
{
    public class int1
    {
        public static void Run()

        {
            Int32 a = 20; //Storage capacity will vary if we use Int32
            Int32 b = 5;

            Console.WriteLine("a : {0}", a); 
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("Maximum Value : {0}", Int32.MaxValue);

        }
    }
}