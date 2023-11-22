using Microsoft.AspNetCore.Mvc;
using StaticFilesDemos.Models; 

namespace StaticFilesDemos.Controllers
{
    public class Home : Controller
    {
        [Route("bookstore/{bookid?}/{isloggedin?}")]
        //[Route("/")]
        public IActionResult Index([FromQuery]int? bookid, [FromRoute]bool? isloggedin,
            Book book){

            //bookid should be supplied
            if (bookid.HasValue == false) {

                //Response.StatusCode = 400;
                //return new BadRequestResult();
                //return Content("Book ID id not supplied");
                return BadRequest("Book ID id not supplied or Empty");
            }


            string? bookId = Convert.ToString(bookid); // Replace with the method that retrieves the book ID
            bool isNullOrEmpty = string.IsNullOrEmpty(bookId);

            //bookid cant be empty
            //if (string.IsNullOrEmpty(Convert.ToString(Request.Query["bookid"])))
            //{
            //    //Response.StatusCode = 400;
            //    //return Content("Book ID cant be null or empty");
            //    return BadRequest("Book ID cant be null or empty");
            //}

            //bookid should be between 1 and 1000
            //int bookid = Convert.ToInt32(Request.Query["bookid"]);
            if (bookid <= 0) {
                //Response.StatusCode = 400;
                //return Content("Book ID cant be less then or equal to Zero");
                return BadRequest("Book ID cant be less then or equal to Zero");
            }
            if (bookid > 1000)
            {
                //Response.StatusCode = 400;
                //return Content("Book ID cant be greater than 1000");
                return BadRequest("Book ID cant be greater than 1000");
            }

            //isLoggedin is true
            if (isloggedin == false)
            {
                //Response.StatusCode = 401;
                //return Content("User must be authenticated");
                //return Unauthorized("User must be authenticated");
                return StatusCode(401);
            }

            return Content($"Book id:{bookid}", "text/plain");

            //return File("ReactJSpdf.pdf", "application/pdf");
            //return new RedirectToActionResult("Books", "Store",new { });
            //return RedirectToAction("Books", "Store", new { id = bookid });
            //302 - Found


            //return RedirectToActionPermanent("Books", "Store", new { id = bookid });
            //return new RedirectToActionResult("Books", "Store", new { }, true);

            //return new ContentResult()
            //{
            //    Content = "<h1>Hello from HOME</h1>",
            //    ContentType = "text/html",
            //};

            //return Content("<h1>Hello from HOME</h1>", "text/html");

        }
        [Route("contact-us/{mobile:regex(^\\d{{10}}$)}")]
        public string Contact()
        {
            return "Hello from Contact";
        }
        [Route("file-download")]
        public FileContentResult About()
        {
            //return new VirtualFileResult("download.png", "image/png");
            //return new PhysicalFileResult(@"C:\Users\Partha.bora\Downloads\DatabaseProgrammingUsingADO.Net.pdf",
            //    "application/pdf");

            byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\Partha.bora\Downloads\download.png");
            return new FileContentResult(bytes, "image/png");
        }

        
    }
}
