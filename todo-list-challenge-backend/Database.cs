using MongoDB.Driver;

namespace todo_list_challenge_backend
{
    static public class Database
    {
        static public MongoClient client = new MongoClient(Settings.MongoDbUrl);
        static public IMongoDatabase db = client.GetDatabase(Settings.MongoDbDatabasName);
    }
}
