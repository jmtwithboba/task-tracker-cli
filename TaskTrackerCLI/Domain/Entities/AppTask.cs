namespace Task_Tracker_CLI.Domain
{
    /// <summary>
    /// This is the task to be tracked.
    /// </summary>
    public class AppTask
    {
        #region Properties
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public AppTaskStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>
        /// The created at.
        /// </value>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Gets or sets the updated at.
        /// </summary>
        /// <value>
        /// The updated at.
        /// </value>
        public DateTime UpdatedAt { get; set; }
        #endregion

        #region Constructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="AppTask"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        public AppTask(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            Status = AppTaskStatus.ToDo;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        #endregion
    }
}