using System.ComponentModel.DataAnnotations;

namespace CoreWEBAPIDemos.Models.DTO
{
    public class LoginRequestsDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
