using FluentAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluentAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        StudentDbContextClass _db;
        public HomeController(StudentDbContextClass sudentDbContextClass) { 
             _db = sudentDbContextClass;
        } 
        [Route("/")]
        public ActionResult Index()
        {

            try
            {
                ////It will return the data from the database by executing SELECT SQL Statement
                //var student = _db.Students.Find(1);
                //ViewBag.out1 = $"FirstName: {student?.FirstName}, LastName: {student?.LastName}";

                ////It will return the data from the context object as the context object tracking the same data
                //var student2 = _db.Students.Find(1);
                //ViewBag.out2 = $"FirstName: {student2?.FirstName}, LastName: {student2?.LastName}";

                ////It will return the data from the database by executing SELECT SQL Statement
                //var student3 = _db.Students.Find(2);
                //ViewBag.out3 = $"FirstName: {student3?.FirstName}, LastName: {student3?.LastName}";
            }
            catch (Exception ex)
            {
                ViewBag.out4 = $"Error: {ex.Message}" ;
            }

            return View();
        }
    }
}
