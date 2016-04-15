using CloningElements.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloningElements.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var initialData = new[] {
                new Gift { Name = "Tall Hat", Price = 39.95 },
                new Gift { Name = "Long Cloak", Price = 120.00 }
            };
            return View(initialData);
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<Gift> gifts)
        {
            // To do: do whatever you want with the data
            if (ModelState.IsValid)
                return View("Completed", gifts);
            else
                return View(gifts); // Redisplay the form with errors
        }

        public PartialViewResult BlankEditorRow()
        {
            return PartialView("_GiftEditorRow", new Gift());
        }
    }
}
