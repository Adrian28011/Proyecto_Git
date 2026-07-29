using Proyecto_Git.Services;
TaskService taskService = new TaskService();
bool salir = false;

while (!salir)
{
    Console.WriteLine("\n=== Gestor de Tareas ===");
    Console.WriteLine("1. Crear tarea");
    Console.WriteLine("2. Ver todas las tareas");
    Console.WriteLine("3. Buscar tarea por Id");
    Console.WriteLine("4. Actualizar tarea");
    Console.WriteLine("5. Eliminar tarea");
    Console.WriteLine("6. Salir");
    Console.Write("Selecciona una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Título: ");
            string title = Console.ReadLine() ?? "";
            Console.Write("Descripción: ");
            string description = Console.ReadLine() ?? "";
            var creada = taskService.CreateTask(title, description);
            Console.WriteLine($"Tarea creada: {creada}");
            break;

        case "2":
            Console.WriteLine("\n--- Listado de tareas ---");
            var tareas = taskService.GetAllTasks();
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
            }
            else
            {
                foreach (var t in tareas)
                {
                    Console.WriteLine(t);
                }
            }
            break;

        case "3":
            Console.Write("Id de la tarea a buscar: ");
            if (int.TryParse(Console.ReadLine(), out int idBuscar))
            {
                var encontrada = taskService.GetTaskById(idBuscar);
                Console.WriteLine(encontrada != null ? $"Tarea encontrada: {encontrada}" : "No se encontró la tarea.");
            }
            else
            {
                Console.WriteLine("Id inválido.");
            }
            break;

        case "4":
            Console.Write("Id de la tarea a actualizar: ");
            if (int.TryParse(Console.ReadLine(), out int idActualizar))
            {
                Console.Write("Nuevo título: ");
                string nuevoTitulo = Console.ReadLine() ?? "";
                Console.Write("Nueva descripción: ");
                string nuevaDescripcion = Console.ReadLine() ?? "";
                Console.Write("¿Completada? (s/n): ");
                bool completada = Console.ReadLine()?.Trim().ToLower() == "s";

                bool actualizado = taskService.UpdateTask(idActualizar, nuevoTitulo, nuevaDescripcion, completada);
                Console.WriteLine(actualizado ? "Tarea actualizada correctamente." : "No se encontró la tarea.");
            }
            else
            {
                Console.WriteLine("Id inválido.");
            }
            break;

        case "5":
            Console.Write("Id de la tarea a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int idEliminar))
            {
                bool eliminado = taskService.DeleteTask(idEliminar);
                Console.WriteLine(eliminado ? "Tarea eliminada correctamente." : "No se encontró la tarea.");
            }
            else
            {
                Console.WriteLine("Id inválido.");
            }
            break;

        case "6":
            salir = true;
            Console.WriteLine("¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Opción no válida, intenta de nuevo.");
            break;
    }
}