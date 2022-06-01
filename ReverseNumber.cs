using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class ReverseNumber
    {
        public ReverseNumber()
        {
            int num;
            int rem = 0;
            int reverse = 0;
            Console.Write("Enter the Number for Reverse : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Reversed : " + num);
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("After Reversed Number : " + reverse);
        }
    }
}
