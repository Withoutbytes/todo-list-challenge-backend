using MongoDB.Driver;

namespace todo_list_challenge_backend.Models.Repository
{
    public static class TasksCollection
    {
        static internal IMongoCollection<TaskRepository> _tasks = Database.db.GetCollection<TaskRepository>("tasks");

        static public async Task<TaskRepository> Create(TaskRepository task)
        {
            await _tasks.InsertOneAsync(task);
            return task;
        }

        static public async Task<UpdateResult> Update(string taskId, bool completed)
        {
            var filter = Builders<TaskRepository>.Filter.Eq(s => s.Id, taskId);
            var update = Builders<TaskRepository>.Update.Set("completed", completed);
            return await _tasks.UpdateOneAsync(filter, update);
        }

        static public async Task<DeleteResult> Delete(string taskId)
        {
            var filter = Builders<TaskRepository>.Filter.Eq(s => s.Id, taskId);
            return await _tasks.DeleteOneAsync(filter);
        }

        static public async Task<UpdateResult> UpdateAllTasks(bool completed)
        {
            var filter = Builders<TaskRepository>.Filter.Empty;
            var update = Builders<TaskRepository>.Update.Set("completed", completed);
            return await _tasks.UpdateManyAsync(filter, update);
        }

        static public TaskRepository Get(string taskId)
        {
            var filter = Builders<TaskRepository>.Filter.Eq(s => s.Id, taskId);
            return _tasks.Find(filter).FirstOrDefault();
        }

        static public async Task<TaskRepository[]> GetAll()
        {
            var r = await _tasks.Find(Builders<TaskRepository>.Filter.Empty).ToListAsync();
            return r.ToArray();
        }

        static public async Task<DeleteResult> DeleteAllAsync()
        {
            return await _tasks.DeleteManyAsync(Builders<TaskRepository>.Filter.Empty);
        }

    }
}
