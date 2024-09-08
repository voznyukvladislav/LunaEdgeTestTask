using System.ComponentModel.DataAnnotations;

namespace LunaEdgeTestTask.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Email { get; set;} = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public DateTime CreatedAt {  get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public List<Task> Tasks { get; set; } = new();
    }
}
