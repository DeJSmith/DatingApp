using System.ComponentModel.DataAnnotations;

namespace Dtos
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}