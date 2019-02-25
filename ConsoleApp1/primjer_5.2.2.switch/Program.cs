using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primjer_5._2._2.@switch
{
    class Program
    {
        static double Safedivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
        static void Main(string[] args)
        {
            double a, b = 0;
            string operacija = "";

            Console.Write("Unesi 1. prirodan broj");
            a = int.Parse(Console.ReadLine());

            Console.Write("Unesi 2. prirodan broj");
            b = int.Parse(Console.ReadLine());

            Console.Write("Unesite operaciju + - * / ");
            operacija = Console.ReadLine();
        }
        catch (Exception ex)
            {

}
            
        
          
        
            
          

            switch (operacija)
            {
                case "+":
                case "plus":
                    Console.WriteLine("Zbroj je {0} + {1} = {2}", a, b, (a + b));
                    break;
                case "-":
                case "minus":
                    Console.WriteLine("Razlika je {0} - {1} = {2}", a, b, (a - b));
                    break;
                case "*":
                case "x":
                    Console.WriteLine("Umnožak je {0} * {1} = {2}", a, b, (a * b));
                    break;

                default:
                    try
                    {
                        //DivideByZeroException
                        Console.WriteLine("Kvocijent je {0} / {1} = {2}", a, b, (a / b));
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine(ex2.ToString());
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
