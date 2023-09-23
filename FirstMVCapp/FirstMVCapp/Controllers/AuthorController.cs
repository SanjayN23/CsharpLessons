using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            Dictionary<int,Author> List=AuthorRepositry.GetAuthorDictionary();
            if (List != null && List.Count>0)
            {
                return View("AuthorList",List.Values.ToList());
            }
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            Author author=AuthorRepositry.FindAuthorByID(id);
            if(author != null)
            {
                return View(author);
            }
            return RedirectToAction("Index");
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            Author author = new Author();
            return View(author);
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepositry.SaveToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            Author author = AuthorRepositry.FindAuthorByID(id);
            if(author!=null){
                return View(author);
            }
            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Author pAuthor)
        {
            try
            {
                AuthorRepositry.UpdateAuthorToFile(pAuthor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            Author author =AuthorRepositry.FindAuthorByID(id);

            if (author != null)
            {
                return View(author);
            }
            return View("Index");
        }
       /* public static Author StringToAuthor(string[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];

            author.BooksPublished = int.Parse(data[2]);
            author.RoyaltyCompany = data[3];
            return author;
        }*/
        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Author pauthor)
        {
            try
            {
                AuthorRepositry.RemoveAuthor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
