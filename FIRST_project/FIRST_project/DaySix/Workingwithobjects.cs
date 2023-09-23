using FIRST_project.DayFive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DaySix
{
    public class Emp
    {
        public int ID;
        public string Name;
        public double Salary;
    }
    internal class Workingwithobjects
    {
        public static void TestOne()
        {
            Object objectOne = new object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");


            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne =new Emp();
            empOne.ID = 1001;empOne.Name = "sam";
            Emp emptwo = empOne;
            //emptwo.ID = 1001; emptwo.Name = "sam";
            Emp empThree =emptwo;
            //empThree.ID = 1001; empThree.Name = "sam";

            bool flag =(empOne.Equals(emptwo));
            Console.WriteLine(flag);
            flag =(empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(emptwo.GetHashCode());//every object has unique hashcode
            Console.WriteLine(empThree.GetHashCode());

        }
    }
}
