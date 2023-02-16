using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class DayofWeek
    {
        public static void CheckingDayofWeek()
        {
            int d=0,y=0,m=0;
            int y0 = 0, x = 0, m0 = 0,d0=0;
            Console.WriteLine("enter day");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            y = Convert.ToInt32(Console.ReadLine());

            y0 = y - (14 - m) / 12;
            x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = m + 12 * ((14 - m) / 12) - 2;
            d0 = (d + x + 31 * m0 / 12) % 7;

            switch(d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thuresday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }

        }
    }
}
