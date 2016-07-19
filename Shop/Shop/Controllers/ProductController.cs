using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public void Index()
        {

        }
        [ActionName("Pokaz")]
        public ActionResult Display(int id)
        {
            throw new Exception("Coś poszło nie tak");
            Product testProduct = new Product();
            testProduct.Id = 1;
            testProduct.Name = "Ksiązka MVC";
            testProduct.Description = "Dużo wiedzy";
            testProduct.Price = 100;

            if (id == testProduct.Id)
                return View("~/Views/Product/Display.cshtml",testProduct);
            else return RedirectToAction("Index","Home");
        }


    }
}