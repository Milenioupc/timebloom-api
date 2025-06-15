using System.ComponentModel.DataAnnotations;

namespace PomodoroApp.Api.Models
{
    public class TaskItemDto
    {
        [Required]
        [StringLength(255, ErrorMessage = "El título no puede exceder 255 caracteres.")]
        public string Title { get; set; } = null!;

        [StringLength(1000, ErrorMessage = "La descripción no puede exceder 1000 caracteres.")]
        public string? Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        [Required]
        [RegularExpression("pending|completed|cancelled",
            ErrorMessage = "El status debe ser pending, completed o cancelled.")]
        public string Status { get; set; } = "pending";

        [Required]
        [RegularExpression("low|medium|high",
            ErrorMessage = "La prioridad debe ser low, medium o high.")]
        public string Priority { get; set; } = "medium";
    }
}
