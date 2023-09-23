using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DaySeven
{
    internal class ThreadDemo
    {
        public static void DemocurrentTh()
        {
            Thread t1 =Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ID : "+id);
            Console.WriteLine("IsAlive" + t1.IsAlive);
            Console.WriteLine("Priority" + t1.Priority);
            Console.WriteLine("Thread State" + t1.ThreadState);
            Console.WriteLine("Current culture" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            t1.CurrentCulture = new CultureInfo("fr-Fr");
            Console.WriteLine(t1.CurrentCulture);
            Console.WriteLine("IsAlive" + t1.IsAlive);
        }
    }
}
