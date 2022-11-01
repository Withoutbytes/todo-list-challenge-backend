namespace todo_list_challenge_backend.Controllers
{
    public partial class TasksController
    {
        public class PatchUpdateAllTasksReq
        {
            public bool completed { get; set; }
        }
    }
}
