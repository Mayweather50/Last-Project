//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using testNdoc.Models;

//namespace testNdoc.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly IWebHostEnvironment webHostEnvironment;

//        public HomeController(IWebHostEnvironment webHostEnvironment)
//        {
//            this.webHostEnvironment = webHostEnvironment;
//        }

//        public IActionResult OnPostMyUploader(IFormFile MyUploader)
//        {
//            if (MyUploader != null)
//            {
//                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Files");
//                string filePath = Path.Combine(uploadsFolder, MyUploader.FileName);
//                using (var fileStream = new FileStream(filePath, FileMode.Create))
//                {
//                    MyUploader.CopyTo(fileStream);
//                }
//                return new ObjectResult(new { status = "success" });

//            }

//            return new ObjectResult(new { status = "fail" });



//        }


//        public IActionResult Index()
//        {
//            return View("Create");
//        }
//    }
//}
