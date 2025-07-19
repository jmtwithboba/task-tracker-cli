using System.Threading.Tasks;
using Task_Tracker_CLI.Domain;

namespace Task_Tracker_CLI.Application
{
    /// <summary>
    /// Tasks handler for CRUD actions for tasks
    /// </summary>
    public class TaskService : ITaskService
    {
        #region Properties        
        private readonly ITaskRepository _repository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskService"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public TaskService(ITaskRepository repo) 
        {
            _repository = repo;
        }
        #endregion

        #region Public Methods
        public void CreateTask(AppTask task)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            task.CreatedAt = DateTime.UtcNow;
            tasks.Add(task);
            _repository.SaveAllTasks(tasks);
            Console.WriteLine($"Task add successfully (ID: {task.Id})");
        }

        public List<AppTask> GetAllTasks()
        {
            return _repository.GetAllTasks();
        }

        public AppTask GetAppbyID(Guid id)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == id);
            return appTask;
        }

        public void UpdateTask(AppTask task)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == task.Id);
            if (appTask != null)
            {
                appTask.Description = task.Description; 
                appTask.Status = task.Status;
                appTask.UpdatedAt = DateTime.UtcNow;
                _repository.SaveAllTasks(tasks);
            }
            Console.WriteLine($"Updated task: {task.Id}");
        }

        public void DeleteTask(Guid id)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == id);
            if (appTask != null)
            {
                tasks.Remove(appTask);
            }
            Console.WriteLine($"Deleted task: {id}");
        }
        #endregion
    }
}
