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
                Console.WriteLine("1: Find Max Of Three Int Number"+
                             "\n2: Find Max Of Three Float Number"+
                             "\n3: Exit"
                            );
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Finding maximum value out of three integer(UC1)
                        int fIntValue = 50, sIntValue = 20, tIntValue = 10;
                        int resIntNum = MaxNumber.MaxIntNumThree(fIntValue, sIntValue, tIntValue);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resIntNum, fIntValue, sIntValue, tIntValue);
                        Console.ReadLine();
                        break;
                    case 2:
                        //Finding maximum value out of three float numbers(UC2)
                        float fstFtVal = 2.2f, secFtVal = 3.4f, tFtVal = 3.2f;
                        float resFtNum = MaxNumber.MaxFloatNumThree(fstFtVal, secFtVal, tFtVal);
                        Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resFtNum, fstFtVal, secFtVal, tFtVal);
                        Console.ReadLine();
                        break;
                    case 3:
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
