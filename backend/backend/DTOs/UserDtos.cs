using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class UserDtos
    {
        public class RegisterDto
        {
            [Required]
            public string Login { get; set; } = string.Empty;
            [Required] 
            [EmailAddress] 
            public string Email { get; set; } = string.Empty;
            [Required]
            public DateTime BirthDate { get; set; }

            [Required]
            [MinLength(6, ErrorMessage = "Hasło musi mieć co najmniej 6 znaków.")]
            public string Password { get; set; } = string.Empty;
        }

        public class LoginDto
        {
            [Required]
            [EmailAddress]
            public string Login { get; set; } = string.Empty;

            [Required]
            public string Password { get; set; } = string.Empty;
        }

        public class UserTokenResponseDto
        {
            public int Id { get; set; }
            public string Login { get; set; } = string.Empty;
            public DateTime BirthDate { get; set; }
            public string Token { get; set; } = string.Empty;
        }
    }
}
