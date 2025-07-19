namespace Task_Tracker_CLI.Domain
{
    /// <summary>
    /// These are the available statuses for the tasks.
    /// </summary>
    public enum AppTaskStatus
    {
        /// <summary>
        /// The task has not been started.
        /// </summary>
        ToDo = 1,

        /// <summary>
        /// The task is in progress.
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// The task is completed.
        /// </summary>
        Done = 3
    }
}