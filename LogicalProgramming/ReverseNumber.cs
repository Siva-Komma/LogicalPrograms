using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public static void Reverse()
        {
            int num = 0, rev = 0, rem = 0;
            Console.WriteLine("Enter the number");
            num=Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The reverse number" + rev);
        }
    }
}
