using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class VendingMachine
    {
        public static void Conversion()
        {
            int amount = 0;
            Console.WriteLine("Enter Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            int[] Notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] NoteCount = new int[8];

            for (int i=0;i<Notes.Length;i++)
            {
                if (amount >= Notes[i])
                {
                    NoteCount[i] = amount / Notes[i];
                    amount%= Notes[i];
                }
            }
            for(int i=0;i<8;i++)
            {
                if (NoteCount[i]!=0)
                {
                    Console.WriteLine(Notes[i]+" : " + NoteCount[i]);
                }
            }
        }
    }
}
