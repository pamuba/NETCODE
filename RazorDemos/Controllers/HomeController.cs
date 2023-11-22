using Microsoft.AspNetCore.Mvc;
using RazorDemos.Models;

namespace RazorDemos.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<Person> people = new List<Person>(){
            new Person(){Name="John", DateOfBirth=DateTime.Parse("2005-05-06"), PersonGender = Gender.Male},
            new Person(){Name="Linda", DateOfBirth=DateTime.Parse("2010-01-09"), PersonGender = Gender.Female},
            new Person(){Name="Susan", DateOfBirth=DateTime.Parse("2007-05-06"), PersonGender = Gender.Female},
            new Person(){Name=null, DateOfBirth=null, PersonGender = Gender.Female},
            };
            //ViewData["people"] = people;
            //ViewBag.a = people;
            //ViewData["appTitle"] = "Asp.Net Core App";
            return View(people);
        }
        [Route("person-details/{name?}")]
        public IActionResult Details(string? name) { 
            if(name == null)
            {
                //return Content("Person name cant be null");
                return View("ErrorPage");
            }

            List<Person> people = new List<Person>(){
            new Person(){Name="John", DateOfBirth=DateTime.Parse("2005-05-06"), PersonGender = Gender.Male},
            new Person(){Name="Linda", DateOfBirth=DateTime.Parse("2010-01-09"), PersonGender = Gender.Female},
            new Person(){Name="Susan", DateOfBirth=DateTime.Parse("2007-05-06"), PersonGender = Gender.Female},
            new Person(){Name=null, DateOfBirth=null, PersonGender = Gender.Female},
            };

            Person? matchingPerson = people.Where(p => p.Name == name).FirstOrDefault();
            return View(matchingPerson);
        }

        //Model -> Action -> View
        [Route("person-with-product")]
        public IActionResult PersonWithProduct() { 
            Person person = new Person() { Name="Susan", PersonGender=Gender.Female, 
                DateOfBirth = Convert.ToDateTime("2004-07-01")};

            //DateTime.TryParseExact() 

            Product product = new Product() { ProductId=1, ProductName="Apple Car"};

            PersonWithProduct personWithProduct = new PersonWithProduct()
            {
                PersonData = person,
                ProductData = product,
            };

            return View(personWithProduct);
        }

    }
}
