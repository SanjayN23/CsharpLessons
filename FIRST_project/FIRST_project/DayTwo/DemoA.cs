using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayTwo
{
    internal class DemoA
    {
        //Global declaration
        int x = 123; //Member variable/Class Variable/Fields
        static int y = 567;
        public static void FirstMethod()
        {
            //Local Variables
            int x = 2000;
            int y = 5000;
            Console.WriteLine(x);//Non static member cannot be accessed
            Console.WriteLine(y);//Local Variables
            Console.WriteLine(DemoA.y);//bGlobal static variable
        }
        public void SecondMethod()
        {
            int y = 500;
            Console.WriteLine(x);
        }
    }
}

namespace FIRST_project.Gavs
{
    internal class DemoA
    {
        
    }
}
