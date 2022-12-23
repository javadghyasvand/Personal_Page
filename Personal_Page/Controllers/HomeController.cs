using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Personal_Page.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Personal_Page.Data;

namespace Personal_Page.Controllers
{
    // [Route("/invertoty/products/")]
    public class HomeController : Controller
    {
        private readonly List<Services> ServiceObjects = new List<Services>
        {
            new Services() { ID = 1, Name = "نقره ای" },
            new Services() { ID = 2, Name = "طلایی" },
            new Services() { ID = 3, Name = "پلاتین" },
            new Services() { ID = 4, Name = "الماس" }
        };

        // [Route("MyIndex/{name?}")]
        public IActionResult Index()
        {
            return View();
        }

        // [HttpGet("MyContact")]
        // [Route("MyContact")]
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(ServiceObjects, "ID", "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact formContact)
        {
            formContact.Services = new SelectList(ServiceObjects, "ID", "Name");
            // if(ModelState.IsValid==false)
         
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نیست  .لطفا مجدد تلاش کنید ";
                return View(formContact);
            }
            ModelState.Clear();
            formContact = new Contact
            {
                Services = new SelectList(ServiceObjects, "ID", "Name")
            };
            ViewBag.succes = "اطلاعات  با موفقیت  ثبت شد";
            return View(formContact);
              // return RedirectToAction("Index");
        }

        public IActionResult DietalesResult(long id)
        {
            var project = Project_Store.GetProjectBy(id);
            return View(project);
        }
        // [HttpPost]
        // // public JsonResult Contact(IFormCollection form)
        // // {
        // //     var name = form["name"];
        // //     var email = form["email"];
        // //     var service = form["service"];
        // //     return Json(Ok());
        // // }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}