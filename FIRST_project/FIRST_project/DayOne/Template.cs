using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayOne
{
    internal class Template
    {
        public static void pyd()
        {
            //Number of lines
            for (int i = 1; i <= 9; i++)
            {
                //To print space
                for (int l = 0; l < 10 - i; l++)
                {
                    Console.Write(" ");
                }
                //To print left side
                for (int k = i; k > 0; k--)
                {
                    if (k != 1)
                    {
                        Console.Write(k);
                    }
                }
                //To print right side
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
