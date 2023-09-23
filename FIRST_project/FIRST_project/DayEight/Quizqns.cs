using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayEight
{
    internal class Quizqns
    {
        public static void Pattern()
        {
            int row = 10;

            for(int i = 0; i < row; i++)
            {
                for(int j = 1; j <= row/2; j++)
                {
                    Console.Write('*'*j);

                }

               for(int k = (row / 2) - 1; k < row-1; k--)
                {
                    Console.Write('*'*k);
                }


            }
          

        }

        public static void PrintPattern()
        {
            int row = 10;

            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            for (int i = row - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

    }
}
