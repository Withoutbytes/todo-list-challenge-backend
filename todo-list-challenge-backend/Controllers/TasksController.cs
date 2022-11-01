using Microsoft.AspNetCore.Mvc;
using todo_list_challenge_backend.Models.Repository;

namespace todo_list_challenge_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : Controller
    {
        [HttpGet(Name = "GetTasks")]
        public Models.Task[] Get()
        {
            return TasksCollection.GetAll();
        }

        [HttpPost(Name = "CreateTask")]
        public bool Post(string name)
        {
            TasksCollection.Create(new Models.Task { completed = true, createdAt = DateTime.Now, name = name });
            return true;
        }

        [HttpPut("{id:length(24)}", Name = "UpdateTask")]
        public bool Put(string taskId, bool completed)
        {
            TasksCollection.Update(taskId, completed);
            return true;
        }

        [HttpDelete("{id:length(24)}", Name = "DeleteTask")]
        public bool Delete(string taskId)
        {
            TasksCollection.Delete(taskId);
            return true;
        }

        [HttpPatch(Name = "UpdateAllTasks")]
        public bool UpdateAllTasks(bool completed)
        {
            TasksCollection.UpdateAllTasks(completed);
            return true;
        }
    }
}
