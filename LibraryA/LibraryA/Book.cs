using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    public class Book
    {
        public  string Title = String.Empty;
        public  string Author = string.Empty;
        public string Genre = String.Empty;
        public DateTime Dateofpublish;
        public int BookPrice;
        public int Totalpages=300;
        public void OpenBook()
        {
            Console.WriteLine("Book is opened");
        }
        public void BookmarkedPage(int pageNo)
        {
            Console.WriteLine($"Page No:{Totalpages} bookmarked");

        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(Totalpages);
        }
    }
}
