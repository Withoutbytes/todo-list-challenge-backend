using Microsoft.Extensions.Configuration;

namespace todo_list_challenge_backend
{
    public class Settings
    {
        public static IConfiguration Configuration { get; set; }
        public static string MongoDbUrl => Settings.Configuration.GetValue<string>("MongoDB:ConnectionString");
        public static string MongoDbDatabasName => Settings.Configuration.GetValue<string>("MongoDB:Database");
    }
}
