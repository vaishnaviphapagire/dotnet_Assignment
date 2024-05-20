using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(args[0]);
           // Console.WriteLine(args[1]);
            int choice=0;
            do
            {
                try
                {
                    Console.WriteLine("Enter first number:");
                    int i1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    int i2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------Calculator Menu--------------");
                    Console.WriteLine("1.Addition");
                    Console.WriteLine("2.Subtraction");
                    Console.WriteLine("3.Multiplication");
                    Console.WriteLine("4.Division");
                    Console.WriteLine("0.Exit");
                    Console.WriteLine("Enter your choice-");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Addition=" + (i1 + i2));
                            break;
                        case 2:
                            Console.WriteLine("Subtraction=" + (i1 - i2));
                            break;
                        case 3:
                            Console.WriteLine("Multiplication=" + (i1 * i2));
                            break;
                        case 4:
                            if(i2==0)
                            {
                                throw new DivideByZeroException();
                            }
                            else
                            {
                                Console.WriteLine("division=" + ((float)i1 / i2));
                            }
                            break;
                           
                        case 0:
                            Console.WriteLine("Thank you!");
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Division by zero is not possible");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Enter valid number!");
                }
            }
            while (choice != 0);
        }
    }
}
