using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        // required in registration to check if user is above 18
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string RoleName {  get; set; }
        // to be filled in profile
        public string? Name { get; set; }
        public string? Surname { get; set; }
        
        [Required]
        public string Login { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [JsonIgnore]
        public string PasswordHash { get; set; } = string.Empty;

        public ICollection<Tasting> Tastings { get; set; } = new List<Tasting>();
    }
}
