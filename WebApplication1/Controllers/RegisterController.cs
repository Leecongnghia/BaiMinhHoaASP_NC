using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using System.IO;

namespace WebApplication1.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IHostingEnvironment hosting;
        public RegisterController(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult XuLy(PersonModel m, IFormFile FHinh)
        {
            
            if (FHinh !=null)
            {
                //Xử lý upload
                //string filename = FHinh.FileName;
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath, "images");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //Sao chép lên Server
                    FHinh.CopyTo(filestream);
                }
                
                m.Picture = filename;

            }
            return View(m);
        }
    }
}
