using Microsoft.AspNetCore.Mvc;

namespace StaticFilesDemos.Models
{
    
    public class Book
    {
        //[FromRoute]
        [FromQuery(Name = "book_id")]
        public int? BookId { get; set; }
        //[FromRoute]
        public string? Author { get; set; }

        public override string ToString()
        {
            return $"Book id {BookId}, Author: {Author}";
        }
    }
}
