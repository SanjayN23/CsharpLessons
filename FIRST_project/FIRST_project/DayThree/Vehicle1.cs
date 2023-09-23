using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayThree
{
    internal abstract class Vehicle1
    {
        public Vehicle1()
        {
            Console.WriteLine("vehicle const");
        }
        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }
    internal class Car : Vehicle1
    {
        public Car()
        {
            Console.WriteLine("Car constructor");
        }
    }
    class VehicleTester
    {
        public static void TestOne()
        {
            //Vehicle1 v = new Vehicle1();
            Vehicle1 tester = new Car();
            tester.Start();
        }
    
        }
    }

