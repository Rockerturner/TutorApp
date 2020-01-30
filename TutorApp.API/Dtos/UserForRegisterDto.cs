using System.ComponentModel.DataAnnotations;

namespace TutorApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long.")]
        public string Password { get; set; }
    }
}