namespace Api.Config.Mongo
{
    public interface IMongoSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string ContestCollection { get; set; }
    }
}
