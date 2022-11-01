using MongoDB.Driver;

namespace todo_list_challenge_backend.Models.Repository
{
    public static class TasksCollection
    {
        static internal IMongoCollection<Task> _tasks = Database.db.GetCollection<Task>("tasks");

        static public void Create(Task task)
        {
            _tasks.InsertOne(task);
        }

        static public void Update(string taskId, bool completed)
        {
            var filter = Builders<Task>.Filter.Eq("_id", taskId);
            var update = Builders<Task>.Update.Set("completed", completed);
            _tasks.UpdateOne(filter, update);
        }

        static public void Delete(string taskId)
        {
            var filter = Builders<Task>.Filter.Eq("_id", taskId);
            _tasks.DeleteOne(filter);
        }

        static public void UpdateAllTasks(bool completed)
        {
            var filter = Builders<Task>.Filter.Empty;
            var update = Builders<Task>.Update.Set("completed", completed);
            _tasks.UpdateMany(filter, update);
        }

        static public Task Get(string taskId)
        {
            var filter = Builders<Task>.Filter.Eq("_id", taskId);
            return _tasks.Find(filter).FirstOrDefault();
        }

        static public Task[] GetAll()
        {
            return _tasks.Find(Builders<Task>.Filter.Empty).ToList().ToArray();
        }

        static public void DeleteAll()
        {
            _tasks.DeleteMany(Builders<Task>.Filter.Empty);
        }

    }
}
