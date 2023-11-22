using Microsoft.AspNetCore.Mvc;

namespace StaticFilesDemos.Controllers
{
    public class StoreController : Controller
    {
        [Route("store/books/{id}")]
        public IActionResult Books()
        {
            int id = Convert.ToInt32(Request.RouteValues["id"]);
            return Content($"The new store/books url {id}");
        }
    }
}
