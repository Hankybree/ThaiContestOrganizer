namespace Api.Config.Mongo;

public class MongoSettings : IMongoSettings
{
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
    public string ContestCollection { get; set; }
}
