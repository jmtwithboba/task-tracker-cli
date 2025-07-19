using System.Text.Json;
using Task_Tracker_CLI.Domain;

namespace Task_Tracker_CLI.Infrastructure
{
    /// <summary>
    /// Json File Implementation of storing Tasks
    /// </summary>
    /// <seealso cref="Task_Tracker_CLI.Domain.ITaskRepository" />
    public class JsonFileTaskRepository : ITaskRepository
    {
        #region Properties
        private const string FilePath = "tasks.json";
        #endregion

        #region Public Methods        
        /// <summary>
        /// Gets all tasks.
        /// </summary>
        /// <returns></returns>
        public List<AppTask> GetAllTasks()
        {
            if (!File.Exists(FilePath))
            {
                return new List<AppTask>();
            }
            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<AppTask>>(json) ?? new List<AppTask>();
        }

        /// <summary>
        /// Saves all tasks.
        /// </summary>
        /// <param name="tasks">The tasks.</param>
        public void SaveAllTasks(List<AppTask> tasks)
        {
            var json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(FilePath, json);
        }
        #endregion
    }
}
