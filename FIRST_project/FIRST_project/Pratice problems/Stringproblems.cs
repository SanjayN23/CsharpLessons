using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.Pratice_problems
{
    internal class Stringproblems
    {
        public static void TestOne()
        {
            Console.WriteLine("enter a string");
            string a= Console.ReadLine();
            Console.WriteLine(a);
            Console.WriteLine(a.Length);
            char[] chars = a.ToCharArray();
            foreach(char c in chars.Reverse())
            {
                Console.Write(c);
            }
        }
        public static void TestTwo()
        {
            Console.WriteLine("enter a string");
            string a = Console.ReadLine();
            Console.WriteLine(a);
            String[] words = a.Split(' ');
            Console.WriteLine(words.Count());

        }
        public static void TestThree() {
            int vowel=0;
            int consonants=0;
            Console.WriteLine("enter a string");
            string a = Console.ReadLine();
            int len = a.Length;
            for(int i = 0; i < len; i++)
            {
                if (a[i] == 'a' || a[i]=='e'|| a[i] == 'i' || a[i] == 'o' || a[i] == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonants++;
                }
            }
            Console.WriteLine(vowel);
            Console.WriteLine(consonants);
            Console.WriteLine(int.MaxValue);
        }
    }
}
