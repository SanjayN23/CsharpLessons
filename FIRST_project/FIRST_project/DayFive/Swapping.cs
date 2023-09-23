using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.Day_5
{
    internal class Swapping
    {
        public static void questionSeven()
        {
            int v1 = 35;
            int v2 = 55;
            Console.WriteLine($"v1={v1},v2={v2}");
           Swap(ref v1, ref v2);
            Console.WriteLine("After swap");
            Console.WriteLine($"v1={v1},v2={v2}");

        }
        public static void Swap(ref int x, ref int y)
        {
            x = x + y;//eg x=10+20
            y=x-y;//y=30-20=10
            x = x - y;//x=30-10=20
        }
        public static void QuestionThreeA()
        {
            String strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");
            int wordCount = words.Length;
            Console.WriteLine($"Word Count {wordCount}");
        }
        public static void QuestionFour()
        {
            Console.WriteLine("Enter a NAME");
            String name = $"{Console.ReadLine()}";
            int len = name.Trim().Length;
            if (len < 8)
            {
                String errorMessage = "Name is Lessthan 8 Char. Try Again...";
                throw new Exception(errorMessage);
            }
            char[] nameCharArray = name.Trim().ToUpper().ToCharArray();
            foreach (var item in nameCharArray)
            {
                int asciiValue = item;
                if (asciiValue < 65 || asciiValue > 90)
                {
                    String errorMessage = "Name Must contain ONLY Alphabets. Try Again...";
                    throw new Exception(errorMessage);
                }
            }
            Console.WriteLine($"Correct Input {name}");
        }
    }
}
