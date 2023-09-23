using System.Text;

namespace FirstMVCApp.Models
{
    public class AuthorRepositry
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            string fName = @"c:\temp\author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExits = System.IO.File.Exists(fName);
            if (isFileExits)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }

                }

            }
            return list;
        }
        public static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.DateOfBirth = DateTime.Parse(data[4]);
            author.BooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = data[2];
            return author;
        }

        //public static Author FindAuthorById(int ID) { }
        public static void SaveToFile(Author pAuthor)
        {
            string fname = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.RoyaltyCompany},{pAuthor.BooksPublished},{pAuthor.DateOfBirth}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id) {
            string fname = @"c:\temp\author.csv";
            Dictionary<int,Author> List = AuthorRepositry.GetAuthorDictionary();

            StringBuilder strAuthor = new StringBuilder(List.Count+100);
            
                foreach(Author author in List.Values) {
                    if (author.AuthorID != id)
                    {
                        strAuthor.Append($"{author.AuthorID},{author.AuthorName},{author.RoyaltyCompany},{author.BooksPublished},{author.DateOfBirth} {Environment.NewLine}");
                    }
                }
            
            File.WriteAllText(fname, strAuthor.ToString());
        }
        public static void SaveAllAuthorToFile(Dictionary<int, Author> pAuthorList)
        {
            string fName = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthorList.Count}Author";
        }
        public static Author FindAuthorByID(int id)
        {
            Dictionary<int, Author> list = GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            String fname = @"c:\temp\author.csv";
            Dictionary<int, Author> List = AuthorRepositry.GetAuthorDictionary();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fname))
            {
                foreach (Author author in List.Values)
                {
                    if (author.AuthorID != pAuthor.AuthorID)
               
                        strAuthor = $"{author.AuthorID},{author.AuthorName},{author.RoyaltyCompany},{author.BooksPublished},{author.DateOfBirth}";
                    else
                        strAuthor =$"{author.AuthorID},{author.AuthorName},{author.RoyaltyCompany},{author.BooksPublished},{author.DateOfBirth}";
                    
                    sw.WriteLine(strAuthor);
                }
            }
        }
        
    }

}
