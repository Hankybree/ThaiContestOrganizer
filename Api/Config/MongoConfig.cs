namespace ThaiContestApi.Config
{
    public class MongoConfig : IMongoConfig
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string ContestCollection { get; set; }
    }
}
