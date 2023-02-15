using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public static void Perfect()
        {
            int num = 0,i=1,sum=0;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            while(sum != num)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("perfect number" + i);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("Sum" + sum);
            if (sum==num)
            {
                Console.WriteLine("\nPerfect number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }
    }
}
