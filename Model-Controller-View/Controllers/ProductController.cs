using Microsoft.AspNetCore.Mvc;
using Model_Controller_View.Models;
using System.Collections.Generic;

namespace Model_Controller_View.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            var dep = new Department { Id = 1, Name = "Electronicos" };
           
            

            List<Product> list = new List<Product>();

            list.Add(new Product { Id = 1, Name = "Iphone 5" , Price = 3456.8  , Department = dep });
            list.Add(new Product { Id = 2, Name = "Iphone 6" , Price = 653.84  , Department = dep });
            list.Add(new Product { Id = 3, Name = "Iphone 7" , Price = 6456.86 , Department = dep });


            return View(list);
        }
    }
}
