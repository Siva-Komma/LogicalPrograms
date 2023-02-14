using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class FibonacciSeries
    {
        public static void Fibonacci()
        {
            int fibo1 = 0, fibo2 = 1, fibo3 = 0,num=0;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFibonacci series: \n" + fibo1);
            Console.WriteLine(fibo2);
            for(int i=2;i<num;i++)
            {
                fibo3 = fibo1+fibo2;
                Console.WriteLine(fibo3);
                fibo1 = fibo2;
                fibo2 = fibo3;
            }
        }
    }
}
