using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace My_application___Calculator
{
    class lines
    {
        string description = "My name is zhike esguerra and im a software developer";
        string calculator = "1 = addition 2 = subtraction 3 = multiplication 4 = division";

        static int addition(int a, int b)
        {
            int ans;
            ans = a + b;
            return ans;
        }
        static int subtraction(int a, int b)
        {
            int ans;
            ans = a - b;
            return ans;
        }
        static int muliplication(int a, int b)
        {
            int ans;
            ans = a * b;
            return ans;
        }
        static int division(int a, int b)
        {
            int ans;
            ans = a / b;
            return ans;
        }
        static void hello()
        {
            Console.WriteLine("The answer is : ");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int a;
                int b;
                int c;
                int i = 0;

                lines lines = new lines();

                Console.WriteLine("Welcome to zhike's Calculator");
                Console.WriteLine(lines.description);

                Console.WriteLine("enter number");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(lines.calculator);
                b = Convert.ToInt32(Console.ReadLine());    

                Console.WriteLine("enter number");
                c = Convert.ToInt32(Console.ReadLine());

                if (b == 1)
                {
                    hello();
                    Console.WriteLine(addition(a, c));
                }
                
            }
        }
    }
}
