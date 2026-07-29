using Proyecto_Git.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Git.Services
{
    internal class TaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;
        public TaskItem CreateTask(string title, string description)
        {
            var task = new TaskItem
            {
                Id = _nextId++,
                Title = title,
                Description = description,
                IsCompleted = false
            };

            _tasks.Add(task);
            return task;
        }
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public TaskItem? GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

    }
}
