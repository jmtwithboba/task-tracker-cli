using Task_Tracker_CLI.Domain;

namespace TaskTrackerCLI.UnitTests
{
    public class TaskServiceTests
    {
        private class InMemoryTaskRepository : ITaskRepository
        {
            public List<AppTask> Tasks = new List<AppTask>();

            public List<AppTask> GetAllTasks()
            {
                return Tasks;
            }

            public void SaveAllTasks(List<AppTask> tasks)
            {
                Tasks = tasks;
            }
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
