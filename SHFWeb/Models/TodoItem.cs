using System;

namespace SHFWeb.Models
{
    public class TodoItem
    {
        public Guid Id { get; set;}
        public bool IsDone { get; set;}
        public string Title { get; set;}
        public DateTimeOffset? DueAt { get; set;}
    }
}