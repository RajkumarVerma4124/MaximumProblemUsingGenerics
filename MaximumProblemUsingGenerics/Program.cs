using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumProblemUsingGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Printing welcome message
            Console.WriteLine("Welcome to the finding maximum number program using generics");

            while (true)
            {
                Console.WriteLine("1: Find Max Of Three Int Number Using Generics"+
                             "\n2: Find Max Of Three Float Number Using Generics"+
                             "\n3: Find Max Of Three String Input Using Generics"+
                             "\n4: Exit"
                            );
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Finding maximum integer value using generics and printing using genric method(UC4 & UC5)
                        int[] intArray = { 34, 23, 40, 36 };
                        MaxNumber<int> resIntNum = new MaxNumber<int>(intArray);
                        resIntNum.PrintMaxValue();
                        Console.ReadLine();
                        break;
                    case 2:
                        //Finding maximum float value using genericsand printing using genric method(UC4 & UC5)
                        float[] floatArray = { 12.5f, 45.65f, 987.45f, 658.78f };
                        MaxNumber<float> resFtNum = new MaxNumber<float>(floatArray);
                        resFtNum.PrintMaxValue();
                        Console.ReadLine();
                        break;
                    case 3:
                        //Finding maximum string value using genericsand printing using genric method(UC4 & UC5)
                        string[] stringArray = { "Airplane", "Airport", "Airspace", "AirCargo" };
                        MaxNumber<string> resStr = new MaxNumber<string>(stringArray);
                        resStr.PrintMaxValue();
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose a right option");
                        break;
                }
            }
        }
    }
}
