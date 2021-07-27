using System;
using System.Threading;
namespace CSharpTraining._2_Datatypes.ValueTypes
{
    public class int1
    {
        public static void int1Run()

        {
            Int32 a = 20; //Storage capacity will vary if we use Int32
            Int32 b = 5;

            if (a == b)
            {
                Console.WriteLine("a is equal to b");
                Thread.Sleep(6000);
            }
            else if (a > b)
            {
                Console.WriteLine("a is greater than b");
                Thread.Sleep(6000);
            }
            else if (b < a)
            {
                Console.WriteLine("b is less than a");
                Thread.Sleep(2000);
            }

        }
    }
}