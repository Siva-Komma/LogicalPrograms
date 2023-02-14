using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PrimeNumber
    {
        public static void Prime()
        {
            int num = 0,i=1,count=0;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("Prime Number: "+num);
            }
            else
            {
                Console.WriteLine("Not a Prime Number: " + num);
            }
        }
    }
}
