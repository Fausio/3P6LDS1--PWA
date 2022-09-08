using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using File = TPC_Flex_Box.Models.File; 

namespace TPC_Flex_Box.Controllers
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

            return View(files);
        }
 
    }
}