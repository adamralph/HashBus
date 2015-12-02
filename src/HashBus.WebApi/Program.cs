namespace HashBus.WebApi
{
    using System;
    using System.Configuration;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var baseUris = ConfigurationManager.AppSettings["BaseUris"]
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(baseUri => baseUri.Trim())
                .Select(baseUri => new Uri(baseUri));

            var mongoConnectionString = ConfigurationManager.AppSettings["MongoConnectionString"];
            var mongoDBDatabase = ConfigurationManager.AppSettings["MongoDBDatabase"];
            var ignoredUserNames = ConfigurationManager.AppSettings["IgnoredUserNames"]
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(userName => userName.Trim());

            App.Run(baseUris, mongoConnectionString, mongoDBDatabase, ignoredUserNames);
        }
    }
}
