using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class MonthlyPayment
    {
        public static void Payment()
        {
            double P = 0, R = 0, Y = 0;
            double payment=0,s=0,n=0,r=0;
            Console.WriteLine("Enter Principle loan amount");
            P=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percent of interest");
            R=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Year");
            Y=Convert.ToDouble(Console.ReadLine());
            r = R/(12*100);
            n = 12 * Y;
            s = 1-Math.Pow((1 + r), (-n));

            payment = (P * r) / s;
            Console.WriteLine("Monthely Payment: " + payment);

        }
    }
}
