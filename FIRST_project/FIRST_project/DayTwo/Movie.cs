using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRST_project.DayTwo
{
    internal class Movie
    {
        public string Title { get; set; } = String.Empty;
        public string Movie_Year { get; set; } = String.Empty;
        public string Movie_Month { get; set; } = String.Empty;
        public string Movie_Date { get; set; } = String.Empty;
        public string Budget { get; set; }
        public override string ToString()
        {
            return $"Title: {this.Title},Movie_year :{this.Movie_Year},Movie_month :{this.Movie_Month},\n"
                +$"Movie_Day: {this.Movie_Date},Budget: {this.Budget}";
        }

        internal class Details
        {
            public static void TestOne()
            {
                Movie details1 = new Movie();
                details1.Title = "Jailer";
                details1.Movie_Year = "2023";
                details1.Movie_Month = "August";
                details1.Movie_Date = "10-August-2023";
                details1.Budget = "600Crores";
                string value = details1.ToString(); 
                Console.WriteLine(value);

            }
        }

    }
}
