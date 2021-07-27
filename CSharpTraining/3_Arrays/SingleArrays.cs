using System;

namespace CSharpTraining.Arrays
{
    public class SingleArrays
    {
        public static void Run()
        {

            //Declaration and initialization
            int[] arrayofIntegers = new int[5];

            arrayofIntegers[0] = 5;
            arrayofIntegers[1] = 7;
            arrayofIntegers[4] = 10;

            Console.WriteLine("\nArray of Integer Length is " + arrayofIntegers.Length);
            Console.WriteLine("First element " + arrayofIntegers[0]);
            Console.WriteLine("Second element " + arrayofIntegers[1]);
            Console.WriteLine("Third element " + arrayofIntegers[2]);
            Console.WriteLine("Last element is " + arrayofIntegers[arrayofIntegers.Length -1]);

            
            //for (int i = arrayofIntegers.Length -1 ; i >=0 ; i--)
            //{
              //  Console.WriteLine($"ArrayofIntegers element {i} is qual to {arrayofIntegers[i]}");
            //}

            

            //Declaration, initialization and assignment (With array length)
            //string[] arrayOfStrings = new string[2] {​​​"Testing", "Development" }​​​;

            //Declaration, initialization and assignment (Without array length. It will be created automatically)
            //bool[] arrayOfBooleans = new[] {​​​true, false, false, true }​​​;

        }
    }
}
