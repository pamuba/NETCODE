using Microsoft.AspNetCore.Mvc;
using ViewComponentsDemo.Models;

namespace ViewComponentsDemo.ViewComponents
{
    //[ViewComponent]
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid) {

            PersonGridModel personModel = new PersonGridModel()
            {
                GridTitle = "Persons List",
                Persons = new List<Person>() {
                    new Person() {PersonName = "John", JobTitle="Manager"},
                    new Person() {PersonName = "Jones", JobTitle="Architect"}
                }
            };
            //ViewData["Grid"] = personModel;

            return View("Sample", grid);
            //try to invoke a partialview Shared/Components/Grid/Default.cshtml
        }
    }
}
