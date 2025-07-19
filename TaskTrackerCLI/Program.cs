
using Task_Tracker_CLI.Application;
using Task_Tracker_CLI.Infrastructure;

JsonFileTaskRepository repo = new JsonFileTaskRepository();
TaskService taskHandler = new TaskService(repo);

