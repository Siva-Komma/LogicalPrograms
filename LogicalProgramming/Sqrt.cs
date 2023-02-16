using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class Sqrt
    {
        public static void Squareroot()
        {
            double t = 0, c = 0, sqrt = 0;
            double epsilon = 1e-15;
            Console.WriteLine("Enter number");
            c = Convert.ToInt32(Console.ReadLine());
            t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            sqrt = Math.Round(t, 2);
            Console.WriteLine("Square root:" +sqrt);
        }
    }
}
