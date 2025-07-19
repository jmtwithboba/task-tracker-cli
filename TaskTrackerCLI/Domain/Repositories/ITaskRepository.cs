namespace Task_Tracker_CLI.Domain
{
    /// <summary>
    /// Interface for Storing Tasks
    /// </summary>
    public interface ITaskRepository
    {
        #region Public Methods
        List<AppTask> GetAllTasks();
        void SaveAllTasks(List<AppTask> tasks);
        #endregion
    }
}
