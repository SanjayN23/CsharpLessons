using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace FirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Movies> movie = MoviesRepositry.GetMovieDetailsList();
            return View(movie);
        }



        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            if (id < 99)
            {
                return RedirectToAction("Index");
            }
            Movies movie = MoviesRepositry.FindMovieById(id);
            return View(movie);
        }



        // GET: MovieController/Create
        public ActionResult Create()
        {
            Movies movie = new Movies();
            return View(movie);
        }



        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Movies movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MoviesRepositry.AddNewMovieDetails(movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            Movies movie = MoviesRepositry.FindMovieById(id);
            return View(movie);
        }



        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Movies movie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MoviesRepositry.UpdateMovieDetails(movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            Movies movie = MoviesRepositry.FindMovieById(id);
            if (movie != null)
                return View(movie);
            return View(movie);
        }



        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection, Movies movie)
        {
            try
            {
                MoviesRepositry.DeleteMovieDetails(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}