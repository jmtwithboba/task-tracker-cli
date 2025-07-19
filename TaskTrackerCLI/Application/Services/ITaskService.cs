using Task_Tracker_CLI.Domain;

namespace Task_Tracker_CLI.Application
{
    /// <summary>
    /// Interface for Task Handler performing CRUD actions on Tasks
    /// </summary>
    public interface ITaskService
    {
        /// <summary>
        /// Creates the task.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns></returns>
        void CreateTask(AppTask task);

        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns></returns>
        List<AppTask> GetAllTasks();

        /// <summary>
        /// Gets the appby identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        AppTask GetAppbyID(Guid id);

        /// <summary>
        /// Updates the task.
        /// </summary>
        /// <param name="task">The task.</param>
        /// <returns></returns>
        void UpdateTask(AppTask task);

        /// <summary>
        /// Deletes the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        void DeleteTask(Guid id);
    }
}
