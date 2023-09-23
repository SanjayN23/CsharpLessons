using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class AuthorController1 : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AuthorController1(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author author)
        {
            string fName = @"c:\temp\author.csv";
            string strBook = $"{author.AuthorID},{author.AuthorName},{author.BooksPublished},{author.DateOfBirth},{author.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strBook);
            }
            return View(author);

        }
        public IActionResult ListAuthors()
        {
            String fName = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        public static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.BooksPublished = int.Parse(data[2]);
          author.DateOfBirth= DateTime.Parse(data[3]);
            author.RoyaltyCompany = data[4];
            return author;
        }
        private readonly string _filePath = @"c:\temp\author.csv";
        [HttpGet]
       
        public IActionResult ModifyAuthor() {
                return View();
            }
            public IActionResult FindAuthor() {

                return View();
            }
            public IActionResult DeleteAuthor()
            {
                return View();
            }
            
        }

    }

