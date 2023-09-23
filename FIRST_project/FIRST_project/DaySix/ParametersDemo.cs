using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DaySix
{
    internal class ParametersDemo
    {
        public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x={x},y={y}");
            OptionalParameters();
            OptionalParameters(x, y);
            OptionalParameters(v2: x, v1: y);//Using Named Arguments
        }
        public static void ByRefMethod(int v1, ref int v2)
        {
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//5, 10
            v1 = v1 + 100;
            v2 = v1 * 2000;
            Console.WriteLine("\tM1==> v1={0},v2={1}", v1, v2);//105, 210000 
        }
        public static void TestByRefMethod()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 10
            ByRefMethod(x, ref y);
            Console.WriteLine("TestM1==> x={0},y={1}", x, y);//5, 210000
        }

        //params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        public static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }
    }
}
