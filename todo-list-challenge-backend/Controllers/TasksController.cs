using Microsoft.AspNetCore.Mvc;
using todo_list_challenge_backend.Models.Repository;

namespace todo_list_challenge_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public partial class TasksController : Controller
    {
        [HttpGet(Name = "GetTasks")]
        public async Task<Models.TaskRepository[]> Get()
        {
            return await TasksCollection.GetAll();
        }

        [HttpPost(Name = "CreateTask")]
        public async Task<Models.TaskRepository> Post(PostReq req)
        {
            return await TasksCollection.Create(new Models.TaskRepository { completed = true, createdAt = DateTime.Now, name = req.name });
        }

        [HttpPut("{taskId:length(24)}", Name = "UpdateTask")]
        public async Task<bool> Put(string taskId, PutRq req)
        {
            var r = await TasksCollection.Update(taskId, req.completed);
            return r.IsAcknowledged;
        }

        [HttpDelete("{taskId:length(24)}", Name = "DeleteTask")]
        public async Task<bool> Delete(string taskId)
        {
            var r = await TasksCollection.Delete(taskId);
            return r.IsAcknowledged;
        }

        [HttpPut]
        [Route("CheckAll")]
        public async Task<bool> CheckAll(PatchUpdateAllTasksReq req)
        {
            var r = await TasksCollection.UpdateAllTasks(req.completed);
            return r.IsAcknowledged;
        }
    }
}
