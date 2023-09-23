using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayTwo
{
    internal class Box
    {
        public static int height;
        public int width;//Can be accessed using object
        public const string var = "hello";
        public int GetHeight() { return height; }
    }
    internal class TestBox
    {
        public static void TestOne()
        {
            
            Box.height = 200;
           // Box.width = 200; varaible is not in static
           Box firstBox =new Box();
            Box secondBox =new Box();
            firstBox.width = 300;
            secondBox.width = 200;
            Console.WriteLine($"First Box ={firstBox.width},{firstBox.GetHeight()}");
            Console.WriteLine($"Second Box={secondBox.width},{secondBox.GetHeight()}");
            Console.WriteLine(Box.var);
        }
    }
}
