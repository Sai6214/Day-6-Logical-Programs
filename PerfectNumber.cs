using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNumber
    {
        public PerfectNumber()
        {
            int num;
            int sum = 0;
            Console.Write("Enter the number for checking Perfect Number or not : ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Perfect Number");
            }
        }
    }
}
