using Microsoft.AspNetCore.Mvc;
using todo_list_challenge_backend.Models.Repository;

namespace todo_list_challenge_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class TasksController : Controller
    {
        [HttpGet(Name = "GetTasks")]
        public Models.Task[] Get()
        {
            return TasksCollection.GetAll();
        }

        [HttpPost(Name = "CreateTask")]
        public bool Post(PostReq req)
        {
            TasksCollection.Create(new Models.Task { completed = true, createdAt = DateTime.Now, name = req.name });
            return true;
        }

        [HttpPut("{id:length(24)}", Name = "UpdateTask")]
        public bool Put(string taskId, PutRq req)
        {
            TasksCollection.Update(taskId, req.completed);
            return true;
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteTask")]
        public bool Delete(string taskId)
        {
            TasksCollection.Delete(taskId);
            return true;
        }

        [HttpPatch]
        [Route("UpdateAllTasks")]
        public bool UpdateAllTasks(PatchUpdateAllTasksReq req)
        {
            TasksCollection.UpdateAllTasks(req.completed);
            return true;
        }
    }
}
