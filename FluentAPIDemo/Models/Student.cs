using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentAPIDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //The Following Property Exists in the Standard Entity

        //public int StandardId { get; set; }
        //To Create a Foreign Key it should have the Standard Navigational Property
        [ForeignKey("StandardReferenceId")]
        public Standard? Standard { get; set; }


    }
}
