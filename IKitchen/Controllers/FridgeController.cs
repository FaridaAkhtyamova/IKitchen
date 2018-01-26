using IKitchen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKitchen.Controllers
{
    public class FridgeController : Controller
    {
        // GET: Fridge
        public ActionResult Fridge()
        {
            var product = new Product {
                Name = "Apple", Amount = 2, DateTimeBought = DateTime.Today, ExpiryDate = new DateTime(2018, 01, 28), MeasureType ="pcs" 
            };
            return View(product);
        }

        public ActionResult All()
        {
            var list = new List<Product>();
            list.Add(new Product
            {
                Name = "Apple",
                Amount = 2,
                DateTimeBought = DateTime.Today,
                ExpiryDate = new DateTime(2018, 01, 28),
                MeasureType = "pcs"
            });
            list.Add(new Product
            {
                Name = "Banana",
                Amount = 10,
                DateTimeBought = DateTime.Today,
                ExpiryDate = new DateTime(2018, 01, 28),
                MeasureType = "pcs"
            });
            return View(list);
        }
    }
}