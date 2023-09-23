using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayFive
{
    internal class Reference
    {
        public static void DoTask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
        public static void DoTaskA(ref int x){// the value of x is reference of v1
            int i = x + 2000;
        x=i;//since there is change in value of x,will affect the value of v1
            Console.WriteLine(x);
            }
    }
}
