using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Country
    {
        /// <summary>
        /// Domain Model Country
        /// </summary>
        [Key] //uniqueidentitiy
        public Guid CountryID { get; set; }
        
        public string? CountryName { get; set; }
    }
}