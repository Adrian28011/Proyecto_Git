using Proyecto_Git.Services;

Console.WriteLine("=== Gestor de Tareas ===");

TaskService taskService = new TaskService();

var nuevaTarea = taskService.CreateTask("Estudiar Git Flow", "Practica de flujo");
Console.WriteLine($"Tarea creada: {nuevaTarea}");

Console.WriteLine("\n--- Listado de tareas ---");
foreach (var t in taskService.GetAllTasks())
{
    Console.WriteLine(t);
}

var tareaBuscada = taskService.GetTaskById(1);
Console.WriteLine($"\nTarea encontrada por Id: {tareaBuscada}");