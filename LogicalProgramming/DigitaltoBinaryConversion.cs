using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class DigitaltoBinaryConversion
    {
        public static void BinaryConversion()
        {
            int num = 0, i = 2,rem=0;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            { 
                    rem = num % i;
                    Console.WriteLine(rem);
                    num = num / i;   
            }
        }
    }
}
