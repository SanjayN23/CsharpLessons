using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayOne
{
    internal class Statements
    {
       public static void TestOne()
        {
            System.Console.WriteLine("Enter age");
            String ageastring=Console.ReadLine();
            int age = int.Parse(ageastring);
            /*if (!IsNumeric(ageastring))
            {
                return;
            }*/
            if(age < 18)
            {
                System.Console.WriteLine("you can't drive");
            }
            else
            {
                System.Console.WriteLine("you can drive");
            }
        }
        /*public static bool IsNumeric(String pValue) {
            bool result;
            if (pValue == null)
            {

            }
        }*/
    }

}
