using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayTwo
{
    internal class Constructor1
    {
        private readonly Constructor1 _board=new Constructor1();
        private Constructor1()
        {
            Console.WriteLine("Scoreboard created");
        }
    }
}
