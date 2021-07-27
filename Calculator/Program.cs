using System;

namespace Calculator
{
    class Program
    {
        static void EnterValues(out float a, out float b)
        {
            Console.Write("Enter Value 1: ");          
            writeA:
            if (float.TryParse(Console.ReadLine(), out float n))
            { 
                a = n; 
            }
            else
            {
                Console.WriteLine("Wrong format...Try again please!");
                goto writeA;
            }
            Console.Write("Enter Value 2: ");
            writeB:
            if (float.TryParse(Console.ReadLine(), out float k))
            { 
                b = k;
            }
            else
            {
                Console.WriteLine("Wrong format...Try again please!");
                goto writeB;
            }    
        }
        static void Addition(float a, float b)
        {
            Console.WriteLine($"\n{a} + {b} = {a + b} \n");
        }

        static void Substraction(float a, float b)
        {
            Console.WriteLine($"\n{a} - {b} = {a - b} \n");
        }
        static void Multipliation(float a, float b)
        {
            Console.WriteLine($"\n{a} * {b} = {a * b} \n");
        }
        static void Division(float a, float b)
        {

            if (b != 0)
            {
                Console.WriteLine($"\n{a} / {b} = {a / b} \n");
            }
            else
            {
                Console.WriteLine("Cannot devide by zero...");
            }

        }


        static void Main(string[] args)
        {
            float a, b;
            string input = "Y";
            while ((input == "Y") && (input != "N"))
            {
                Console.WriteLine(@"Press any following key to perform an arithmetic operation:

 1 - Addition
 2 - Substraction
 3 - Multipliation                            
 4 - Division
");
                string numberOfOperations = Console.ReadLine();
                switch (numberOfOperations)
                {
                    case "1":
                        EnterValues(out a, out b);
                        Addition(a, b);
                        break;
                    case "2":
                        EnterValues(out a, out b);
                        Substraction(a, b);
                        break;
                    case "3":
                        EnterValues(out a, out b);
                        Multipliation(a, b);
                        break;
                    case "4":
                        EnterValues(out a, out b);
                        Division(a, b);
                        break;
                    default:
                        Console.WriteLine("Wrong number...");
                        break;
                }

                Letter:
                Console.WriteLine("Do you want to continue again (Y/N)");
                input = Console.ReadLine();
                if ((input != "Y") && (input != "N"))
                    goto Letter;

            }

        }
    }
}
