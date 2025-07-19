using Task_Tracker_CLI.Domain;

namespace Task_Tracker_CLI.Application
{
    /// <summary>
    /// Interface for Task Handler performing CRUD actions on Tasks
    /// </summary>
    public interface ITaskService
    {
        /// <summary>
        /// Adds the task.
        /// </summary>
        /// <param name="description">The description.</param>
        void AddTask(string description);

        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns></returns>
        List<AppTask> GetAllTasks();

        /// <summary>
        /// Gets all tasks based on a given status.
        /// </summary>
        /// <returns></returns>
        List<AppTask> GetAllTasks(AppTaskStatus status);

        /// <summary>
        /// Updates the task description.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="description">The description.</param>
        void UpdateTask(Guid id, string description);

        /// <summary>
        /// Updates the task status.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="description">The description.</param>
        void UpdateTask(Guid id, AppTaskStatus status);

        /// <summary>
        /// Deletes the task.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        void DeleteTask(Guid id);
    }
}
