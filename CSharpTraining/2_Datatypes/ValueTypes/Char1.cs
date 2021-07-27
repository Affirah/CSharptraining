using System;
using System.Threading;
namespace CSharpTraining._2_Datatypes.ValueTypes
{
    public class Char1

    {
        public static void CharRun()
        {
            Char ch1 = 'a'; //Storing character a in variable ch
            Char ch2 = (char)90; // Storing the int value of Z as Z = 90

            Console.WriteLine("Displays the character = " + ch1);
            Console.WriteLine("Displays the Character of value 90 = " + ch2);
            Thread.Sleep(6000);
        }
    }
}
