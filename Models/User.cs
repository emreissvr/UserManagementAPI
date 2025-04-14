using System.ComponentModel.DataAnnotations;

namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MinLength(2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;
    }
}
