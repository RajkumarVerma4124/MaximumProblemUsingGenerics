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

            while(true)
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
                        //Finding maximum value out of three integer using generics(Ref1 & Ref2)
                        int fIntValue = 50, sIntValue = 20, tIntValue = 10;
                        int resIntNum = new MaxNumber<int>(fIntValue, sIntValue, tIntValue).ShowMax();
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resIntNum, fIntValue, sIntValue, tIntValue);
                        Console.ReadLine();
                        break;
                    case 2:
                        //Finding maximum value out of three float numbers using generics(Ref1 & Ref2)
                        float fstFtVal = 2.2f, secFtVal = 3.4f, tFtVal = 3.2f;
                        float resFtNum = new MaxNumber<float>(fstFtVal, secFtVal, tFtVal).ShowMax();
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resFtNum, fstFtVal, secFtVal, tFtVal);
                        Console.ReadLine();
                        break;
                    case 3:
                        //Finding maximum value out of three string input using generics(Ref1 & Ref2)
                        string fstStr = "Airport", secStr = "Airplane", thirdStr = "Airspace";
                        string resStr = new MaxNumber<string>(fstStr, secStr, thirdStr).ShowMax();
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resStr, fstStr, secStr, thirdStr);
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
