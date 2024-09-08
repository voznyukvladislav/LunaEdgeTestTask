using LunaEdgeTestTask.Data.Enums;
using System.ComponentModel.DataAnnotations;
using TaskStatus = LunaEdgeTestTask.Data.Enums.TaskStatus;

namespace LunaEdgeTestTask.Models
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set;}
        public DateTime? DueDate { get; set; }

        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = new();
    }
}
