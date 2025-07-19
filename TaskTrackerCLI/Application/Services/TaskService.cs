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
        /// <summary>
        /// Adds the task.
        /// </summary>
        /// <param name="task">The task.</param>
        public void AddTask(string description)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask task = new AppTask(description);
            task.CreatedAt = DateTime.UtcNow;
            tasks.Add(task);
            _repository.SaveAllTasks(tasks);
            Console.WriteLine($"Task add successfully (ID: {task.Id})");
        }

        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns></returns>
        public List<AppTask> GetAllTasks()
        {
            return _repository.GetAllTasks();
        }

        /// <summary>
        /// Gets all tasks based on a given status.
        /// </summary>
        /// <returns></returns>
        public List<AppTask> GetAllTasks(AppTaskStatus status)
        {
            return _repository.GetAllTasks().Where(x => x.Status == status).ToList();
        }

        /// <summary>
        /// Updates the task description.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="description">The description.</param>
        public void UpdateTask(Guid id, string description)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == id);
            if (appTask != null)
            {
                appTask.Description = description; 
                appTask.UpdatedAt = DateTime.UtcNow;
                _repository.SaveAllTasks(tasks);
            }
            Console.WriteLine($"Updated task: {id}");
        }

        /// <summary>
        /// Updates the task status.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="status"></param>
        public void UpdateTask(Guid id, AppTaskStatus status)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == id);
            if (appTask != null)
            {
                appTask.Status = status;
                appTask.UpdatedAt = DateTime.UtcNow;
                _repository.SaveAllTasks(tasks);
            }
            Console.WriteLine($"Updated task: {id}");
        }

        /// <summary>
        /// Deletes the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void DeleteTask(Guid id)
        {
            List<AppTask> tasks = _repository.GetAllTasks();
            AppTask appTask = tasks.FirstOrDefault(x => x.Id == id);
            if (appTask != null)
            {
                tasks.Remove(appTask);
                _repository.SaveAllTasks(tasks);
            }
            Console.WriteLine($"Deleted task: {id}");
        }
        #endregion
    }
}
