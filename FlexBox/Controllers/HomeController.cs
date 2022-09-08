using FlexBox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using File = FlexBox.Models.File;

namespace FlexBox.Controllers
{
    public class HomeController : Controller
    {
        [Obsolete]
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;

        [Obsolete]
        public HomeController(Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        [Obsolete]
        public IActionResult Index()
        {
            //Fetch all files in the Folder (Directory).
            string[] filePaths = Directory.GetFiles(Path.Combine(this.Environment.WebRootPath, "imgs/"));
            //Copy File names to Model collection.
            List<File> files = new List<File>();
            foreach (string filePath in filePaths)
            {
                files.Add(new File { Description = Path.GetFileName(filePath) });
            }

            return View(new IndexViewModel()
            {
                FistRow = files.Take(4).ToList(),
                SecundRow = files.Skip(4).Take(4).ToList()
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
