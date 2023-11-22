using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
using ViewsDemo.Models;

namespace ViewsDemo.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["appTitle"] = "ASP.NET Core Demo App";
            List<Person> persons = new List<Person>(){
                new Person(){Name="John", DateOfBirth=DateTime.Parse("2005-05-06"), Gender = "Male"},
                new Person(){Name="Linda", DateOfBirth=DateTime.Parse("2010-01-09"), Gender = "Female"},
                new Person(){Name="Susan", DateOfBirth=DateTime.Parse("2007-05-06"), Gender = "Female"},
            };
            ViewData["persons"] = persons;
            return View(); //Index.cshtml
            //return View("abc");
            //return new ViewResult() { ViewName = "abc" };
        }
    }
}

///localhost:5045/home/Index
