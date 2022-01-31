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
                        //Finding maximum integer value using generics(UC4)
                        int[] intArray = { 34, 23, 40, 36 };
                        int resIntNum = new MaxNumber<int>(intArray).ShowMax();
                        Console.WriteLine("Maximum value from given number is : {0}", resIntNum);
                        Console.ReadLine();
                        break;
                    case 2:
                        //Finding maximum float value using generics(UC4)
                        float[] floatArray = { 12.5f, 45.65f, 987.45f, 658.78f };
                        float resFtNum = new MaxNumber<float>(floatArray).ShowMax();
                        Console.WriteLine("Maximum value from given float number is : {0} ", resFtNum);
                        Console.ReadLine();
                        break;
                    case 3:
                        //Finding maximum string value using generics(UC4)
                        string[] stringArray = { "Airplane", "Airport", "Airspace", "AirCargo" };
                        string resStr = new MaxNumber<string>(stringArray).ShowMax();
                        Console.WriteLine("Maximum value from given string is : {0} ", resStr);
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
