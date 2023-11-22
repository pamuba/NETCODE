using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        //[Bind(nameof(Person.PersonName), nameof(Person.Email))]
        [Route("register")]
        public IActionResult Index([FromBody]Person person)
        {
            if (!ModelState.IsValid) {
                //List<string> errorsList = new List<string>();
                //foreach (var value in ModelState.Values) {
                //    foreach (var error in value.Errors) {
                //        errorsList.Add(error.ErrorMessage);
                //    }
                //}

                List<string> errorsList = ModelState.Values.SelectMany(value => 
                value.Errors).Select(err => 
                err.ErrorMessage).ToList();

                string errors = string.Join("\n", errorsList);
                return BadRequest(errors);
            }
           
            return Content($"{person}");
        }
    }
}
