namespace todo_list_challenge_backend
{
    public class Settings
    {
        public static string MongoDbUrl => Environment.GetEnvironmentVariable("MONGODB_URL");
        public static string MongoDbDatabasName => Environment.GetEnvironmentVariable("MONGODB_DATABASE_NAME");
    }
}
