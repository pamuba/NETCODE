using Microsoft.AspNetCore.Mvc;

namespace middlewareDemo.Controllers
{
    public class HomeController : Controller
    {
        //[Route("sayHello")]
        //[Route("sayHello1")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult()
            //{
            //    ContentType = "text/html",
            //    Content = "<b>Hello from method1</b>"
            //};

            return Content("<b>Hello from Index</b>", "text/html");
        }
    }
}
