using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class TemperaturConversion
    {
        public static void Conversion()
        {
            int C = 0,Celsius=0,Fahrenheit=0, F = 0;
            Console.WriteLine("Enter Temperature in Celsius to convert Fahrenheit");
            C=Convert.ToInt32(Console.ReadLine());
            Fahrenheit = (C * 9 / 5) + 32;
            Console.WriteLine("After converting Celsius : {0} to Fahrenheit: {1}", C, Fahrenheit);

            Console.WriteLine("Enter Temperature in Fahrenheit to convert to Celsius");
            F = Convert.ToInt32(Console.ReadLine());
            Celsius = (F - 32) *5/9;
            Console.WriteLine("After converting Celsius : {0} to Fahrenheit: {1}", F,Celsius);

        }
    }
}
