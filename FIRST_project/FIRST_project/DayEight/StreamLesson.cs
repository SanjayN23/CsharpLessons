using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayEight
{
    internal class StreamLesson
    {
        public static void TestOne()
        {
            char ch;
            Console.WriteLine("Press a key followed by enter");
            int x=Console.Read();
            ch = (char)x;
            Console.WriteLine("\n"+x+ "your keyis :"+ch);
        }
        public static void TestTwo()
        {
            char? ch = ' ';
            Console.WriteLine("Press a key q to exit");
            

            while (ch != 'q' && ch!=null)
            {
                ch = (char)Console.Read();
                Console.WriteLine("Your key is: "+ch);
            }
        }
        public static void TestThree()
        {
            Console.Out.WriteLine("Enter a sentence");
            string? str = Console.ReadLine();
            Console.Out.WriteLine(" "+str);
        }
        public static void TestNullableType() {
            int? x = 0;
            x = null;
            if(x.HasValue)
            {
                Console.WriteLine(x.Value); 
            }
            else
                Console.WriteLine(x.GetValueOrDefault());
        }
    }
}
