using Microsoft.AspNetCore.Mvc;
using Model_Controller_View.Models;
using System.Collections.Generic;

namespace Model_Controller_View.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronicos" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            return View(list);
        }
    }
}
