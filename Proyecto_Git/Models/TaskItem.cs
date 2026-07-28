using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Git.Models
{
    internal class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title} - {Description} - {(IsCompleted ? "Completada" : "Pendiente")}";
        }
    }
}
