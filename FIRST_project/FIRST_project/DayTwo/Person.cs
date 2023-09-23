using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayTwo
{
	internal class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Title {get; set; }=string.Empty;
		public string Address { get; set; } = string.Empty;

		public string City { get; set; } =string.Empty;
		public string Region { get; set; } = string.Empty;
		public string PostalCode { get; set; }= string.Empty;
		public string Country { get; set; } = string.Empty;
		public string Phone { get; set; }
        public override string ToString()
        {
			return $"ID:{this.Id},Name:{Title} {FirstName} {LastName} ,\n" 
				+ $"Address:{Address},City:{City},State:{Region},\n" 
				+ $"ZIP:{PostalCode},Country:{Country},Phone:{Phone}";

		}

    }
	internal class TestPerson
	{
		public static void TestOne()
		{
			Person firstperson = new Person();
			firstperson.Id = 1;
			firstperson.FirstName ="Sanjay";
			firstperson.LastName = "nagaraj";
			firstperson.Title = "c-sharp";
			firstperson.Address = "orchid springs";
			firstperson.City = "chennai";
			firstperson.Phone = "81224e09";
			firstperson.Country = "India";
			firstperson.PostalCode = "12345";


		}
	}
}
