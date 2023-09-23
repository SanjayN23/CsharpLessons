using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DaySix.NewFolder
{
    internal class Emp
    {
        public int Eno = 0;
        private readonly Address address;
        public Emp()
        {
            address = new Address(this);
        }
        public Address GetAddress()
        {
            return address;
        }

         //Inner class
        public class Address
        {
            public string Address1;
            public string Address2;
            private readonly Emp e1;
            internal Address(Emp Outeremp)
            {
                if (Outeremp == null)
                {
                    throw new NullReferenceException("Outer emp is Null");
                    e1 = Outeremp;
                }
            }
            public override string ToString()
            {
                return Address1 + " " + Address2;
            }
        }
    }
    class TestEmp
    {
        public static void TestA()
        {
            try
            {
                Emp.Address address = new Emp.Address(null);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Emp e1 = new Emp();
            //Inner class object
            Emp.Address add = e1.GetAddress();
            add.Address1 = "Ambattur";
            add.Address2 = "Chennai";
            Console.WriteLine($"Address1:{add.Address1}");
            Console.WriteLine($"Address2:{add.Address2}");
        }
    }
}

