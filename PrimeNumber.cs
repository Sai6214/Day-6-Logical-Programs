using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PrimeNumber
    {
        public PrimeNumber()
        {
            int num;
            Console.Write("enter the number for checking Prime or not : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is not Prime Number ");
                }
                else
                {
                    Console.WriteLine(num + " is a Prime Number ");
                }
            }
        }
    }
}
