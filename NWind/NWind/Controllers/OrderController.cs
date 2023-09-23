using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NWind.Models;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NWind.Controllers
{
    // GET: OrderController

    public class OrderController : Controller
    {

        private RepositoryOrders _repositoryOrders;


        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        public IActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);
            return View(idsViewModel);
        }
        public ActionResult Details(int id)
        {
            Order order = _repositoryOrders.FindOrderById(id);
            List<OrderDetail> detail = _repositoryOrders.FindOrderDetailsByOrderId(id);
            ViewData["OrderDetails"] = detail;
            return View(order);
        }


        public IActionResult OrderDetails(int id)

        {

            List<OrderDetail> order = _repositoryOrders.FindOrderDetailsByOrderId(id);

            return View();

        }



        // GET: OrderController/Create

        public ActionResult Create()

        {

            return View();

        }



        // POST: OrderController/Create

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Create(IFormCollection collection)

        {

            try

            {

                return RedirectToAction(nameof(Index));

            }

            catch

            {

                return View();

            }

        }



        // GET: OrderController/Edit/5

        public ActionResult Edit(int id)

        {

            return View();

        }



        // POST: OrderController/Edit/5

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Edit(int id, IFormCollection collection)

        {

            try

            {

                return RedirectToAction(nameof(Index));

            }

            catch

            {

                return View();

            }

        }



        // GET: OrderController/Delete/5

        public ActionResult Delete(int id)

        {

            return View();

        }



        // POST: OrderController/Delete/5

        [HttpPost]

        [ValidateAntiForgeryToken]

        public ActionResult Delete(int id, IFormCollection collection)

        {

            try

            {

                return RedirectToAction(nameof(Index));

            }

            catch

            {

                return View();

            }
        }
    }
}
                