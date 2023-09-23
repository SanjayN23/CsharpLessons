using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayOne
{
    internal class ValueTypeLesson
    {
        public static void TestValueTypes()
        {
            byte a = 255;
            Console.WriteLine(a);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(long.MaxValue);
            float f1 = 52.678f;
        }
        public static void TestMethod() {
            Console.WriteLine("test");
        }
    }
}
