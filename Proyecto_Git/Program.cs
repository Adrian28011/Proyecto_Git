using Proyecto_Git.Services;

Console.WriteLine("=== Gestor de Tareas ===");

TaskService taskService = new TaskService();

var nuevaTarea = taskService.CreateTask("Estudiar Git Flow", "Practica de flujo");
Console.WriteLine($"Tarea creada: {nuevaTarea}");