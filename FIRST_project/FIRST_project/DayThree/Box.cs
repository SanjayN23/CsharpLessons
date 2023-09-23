using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;
        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"Height:{Height}, Length:{Length}, Width:{Width}";
        }
    }
    internal class WoodenBox : Box
    {
        public WoodenBox():base(1) 
        {
            Console.WriteLine("Wooden Box constructor");
        }
        public WoodenBox(int a) : base(a)
        {

        }
        public WoodenBox(int z,int y): base(y)
        {

        }
        public void Add(int a,int b)
        {
            Console.WriteLine($"{a} {b}");
            int x=a;
            int y=b;
            Console.WriteLine(x+y);
        }
        public override string ToString()
        {
            return "Sanjay";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(100);
            box.Height = 100;
            box.Width = 100;
            // box.Add(); this produces error
            box.Open();
            box.Close();
        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();
                box.Height = 20;
            box.Length = 10;
                box.Width = 30;
                box.Open();
                box.Close();
            int a=9; 
            int b=10;
            box.Add(a,b);
            Console.WriteLine(box.ToString());
        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 20;
            box.Length = 10;
            box.Width = 30;
            box.Open();
            box.Close();
            int a = 9;
            int b = 10;
           //box.Add(a, b);
            Console.WriteLine(box.ToString());
        }
    }
}
