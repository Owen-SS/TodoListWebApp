using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TodoListWebApp.Models
{
    public enum TaskStatus
    {
        ToDo,
        InProgress,
        Complete
    }

    public class TodoModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }
        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}