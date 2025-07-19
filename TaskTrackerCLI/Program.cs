
using Task_Tracker_CLI.Application;
using Task_Tracker_CLI.Domain;
using Task_Tracker_CLI.Infrastructure;

TaskService taskHandler = new TaskService(new JsonFileTaskRepository());

if (args.Length == 0)
{
    Console.WriteLine("No command provided.");
    return;
}

var command = args[0].ToLower();

try
{
    switch (command)
    {
        case "add":
            taskHandler.AddTask(args[1]);
            break;
        case "update":
            taskHandler.UpdateTask(Guid.Parse(args[1]), args[2]);
            break;
        case "delete":
            taskHandler.DeleteTask(Guid.Parse(args[1]));
            break;
        case "mark-in-progress":
            taskHandler.UpdateTask(Guid.Parse(args[1]), AppTaskStatus.InProgress);
            break;
        case "mark-done":
            taskHandler.UpdateTask(Guid.Parse(args[1]), AppTaskStatus.Done);
            break;
        case "list":
            if (args.Length > 1)
            {
                switch (args[1]) 
                {
                    case "todo":
                        taskHandler.GetAllTasks(AppTaskStatus.ToDo);
                        break;
                    case "in-progress":
                        taskHandler.GetAllTasks(AppTaskStatus.InProgress);
                        break;
                    case "done":
                        taskHandler.GetAllTasks(AppTaskStatus.Done);
                        break;
                }
            }
            else
            {
                taskHandler.GetAllTasks();
            }
            break;
        default:
            Console.WriteLine("Unknown command.");
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}