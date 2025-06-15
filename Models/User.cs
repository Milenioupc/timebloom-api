﻿namespace PomodoroApp.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Relaciones:
        // public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
        //public ICollection<PomodoroSession> Sessions { get; set; } = new List<PomodoroSession>();
    }
}
