using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class FibonacciSeries
    {
        public FibonacciSeries()
        {
            int num1 = 0;
            int num2 = 1;
            int result;
            int fibo;
            Console.Write("enter the number where Fibonacci Series Till you want : ");
            fibo = int.Parse(Console.ReadLine());
            Console.WriteLine("0");
            Console.WriteLine("1");
            for (int i = 0; i < fibo; i++)
            {
                result = num1 + num2;
                Console.WriteLine(result);
                num1 = num2;
                num2 = result;
            }

        }
    }
}
