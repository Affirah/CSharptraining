using System;


namespace CSharpTraining._4_Loops
{
   public class ForLoop
    {
        public static void Run()
        {

            int[] arrayofIntegers2 = new int[10];
            Console.WriteLine("\nArray of Integers2\n");

            for (int i = 0; i < arrayofIntegers2.Length; i++)
            {
                Console.WriteLine($"ArrayofIntegers2 element {i} is equal to {arrayofIntegers2[i]}");
                
            }

            
            int[] arrayofIntegers3 = new int[20];
            Console.WriteLine("\nArray of Integers3\n");

            for (int a = 0; a < arrayofIntegers3.Length; a++)
            {
                
                arrayofIntegers3[a] = a+1;
                Console.WriteLine($"ArrayofIntegers3 element {a} is equal to {arrayofIntegers3[a]}");

            }

            int[] arrayofIntegers20 = new int[20];
            Console.WriteLine("\nReverted Data\n");

            for(int a = arrayofIntegers20.Length-1; a >=0 ; a--)
            {

                arrayofIntegers20[a] = a;
                Console.WriteLine($"Reverted Data {a} is equal to {arrayofIntegers20[a]+1}");

            }
            //for (int i = arrayofIntegers.Length -1 ; i >=0 ; i--)
            //{
            //  Console.WriteLine($"ArrayofIntegers element {i} is qual to {arrayofIntegers[i]}");
            //}

        }

    }
}
