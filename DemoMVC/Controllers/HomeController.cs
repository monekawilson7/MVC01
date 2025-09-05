using FSharp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
         /*   var result = new ContentResult();
            result.Content = "Hello from Index page";
            //result.StatusCode = StatusCodes.Status200OK;
            result.StatusCode = (int)HttpStatusCodes.OK;
            result.ContentType = "text/html";
            return result;*/

            // Index
            //views/Home/index.cshtml
            //Razor view
            return View();
        }
        [HttpGet]
        public IActionResult Privacy() {
        return View();
        }
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        /*public RedirectResult Update() { 
        // Update Logic
        var result = new RedirectResult("https://www.Google.com");
           return result;
        }*/

        /* public IActionResult Update()
         {
             // Update Logic
             *//* var result = new RedirectToActionResult(nameof(ProductsController.Get),
                  "Products", new {id=10});
              return result;*//*
             return RedirectToAction("Index", "", new { id=10} );
         }*/
        //JsonResult
        //NotFound
        //BadRequestResult
        //ViewResult
    }
}
