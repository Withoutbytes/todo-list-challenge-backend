using MongoDB.Driver;

namespace todo_list_challenge_backend
{
    public class Database
    {
        public MongoClient client;
        public IMongoDatabase db;

        public Database()
        {
            client = new MongoClient(Settings.MongoDbUrl);
            db = client.GetDatabase(Settings.MongoDbDatabasName);
        }
    }
}
