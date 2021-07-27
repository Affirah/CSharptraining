using System;
using CSharpTraining._0_FirstSteps;
using CSharpTraining._2_Datatypes.ValueTypes;
using CSharpTraining.Arrays;
using CSharpTraining._4_Loops;


namespace CSharpTraining
{
    public class Program
    {
        private const string nooption = "No such Option , Sorry - Try Again";
        //private const string options = "Please select from the below options: \n 1.Bool;\n 2.Char; \n 3.Decimal; \n 4.Double; \n 5.Float;\n 6.Int32;\n 7.Long; \n 8.Short \n 9.Exit";
        private const string NotInteger = "Please enter Integer value";
        //private static string selection = "";



        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Lessons Available :\n\n0 - DataTypes\n1 - Arrays\n");
            Console.WriteLine("Please select a Lesson:");
            var answer = Console.ReadLine();
            bool isInt = int.TryParse(answer, out var lessonnumber);
            bool Exit = true;
            while (Exit)

            {
                try

                {
                    if (!isInt)
                        Console.WriteLine(NotInteger);
                    else
                    {


                        //var selection = Console.ReadLine();

                        switch (lessonnumber)
                        {
                            case 0:
                                Console.Clear();
                                Console.WriteLine("The following ValueTypes Available\n\n 1.Bool;\n 2.Char; \n 3.Decimal; \n 4.Double; \n 5.Float;\n 6.Int32;\n 7.Long; \n 8.Short \n 9.Exit");
                                var answer2 = Console.ReadLine();
                                bool isInt2 = int.TryParse(answer2, out var valuetypenumber);

                                if (!isInt2)
                                    Console.WriteLine(NotInteger);

                                else
                                {

                                    switch (valuetypenumber)

                                    {
                                        
                                        case 1:
                                            Console.WriteLine("You have selected Bool");
                                            Bool1.BoolRun();
                                            break;

                                        case 2:
                                            Console.WriteLine("You have selected Char");
                                            Char1.CharRun();
                                            break;

                                        case 3:
                                            Console.WriteLine("You have selected Decimal");
                                            Decimal1.DecimalRun();
                                            break;

                                        case 4:
                                            Console.WriteLine("You have selected Double");
                                            Double1.DoubleRun();
                                            break;

                                        case 5:
                                            Console.WriteLine("You have selected Float");
                                            Float1.FloatRun();
                                            break;

                                        case 6:
                                            Console.WriteLine("You have selected int32");
                                            int1.int1Run();
                                            break;

                                        case 7:
                                            Console.WriteLine("You have selected Long");
                                            Long1.LongRun();
                                            break;

                                        case 8:
                                            Console.WriteLine("You have selected Short");
                                            Short1.ShortRun();
                                            break;


                                        case 9:
                                            Exit = false;
                                            break;

                                        default:
                                            Console.WriteLine(nooption);
                                            break;
                                    }
                                }
                                break;

                            case 1:
                                Console.WriteLine("\n***********ARRAYS**********\n");
                                Console.WriteLine("\nPlease select Type\n\n1.Single Arrays\n2.ForLoop\n");
                                var answer3 = Console.ReadLine();
                                bool isInt3 = int.TryParse(answer3, out var arraytype);

                                if (!isInt3)
                                    Console.WriteLine(NotInteger);

                                switch(arraytype)

                                {
                                    case 1:
                                        SingleArrays.Run();
                                        break;

                                    case 2:
                                        ForLoop.Run();
                                        break;

                                }
                                break;
                        }
                }
        }

                catch
                {
                    Console.WriteLine("\nWrong Datatype");
                    
                }
                Console.WriteLine("\nSelect another option");
                                
            }
           
        }
    } 
}


