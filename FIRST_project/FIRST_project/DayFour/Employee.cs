using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayFour
{
    public enum City { Chennai,Bangalore,Hyderabad};
    public enum Designation { Manager,Admin,Developer};
    internal class Employee
    {
        public readonly int EId;
        public string Name=String.Empty;
        public City Ecity;
        public Designation JobTitle;
        public Employee(int v1) { EId = v1; }
        public override string ToString()
        {
            String Output=string.Empty;
            Output = $"Details of a employee are: ID={EId} {Name} {Ecity} {JobTitle}";
            return Output ;
        }
        class TestEmployee
        {
            public static void TestOne()
            {
                Employee E1=new Employee(300);
                E1.Name = "john";
                E1.Ecity = City.Bangalore;
                E1.JobTitle = Designation.Developer;
                string output=E1.ToString();
                Console.WriteLine(output);  
            }
        }
    }
}
