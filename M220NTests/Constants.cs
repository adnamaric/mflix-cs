using Microsoft.Extensions.Configuration;

namespace M220NTests
{
    public static class Constants
    {
        public static string MongoDbConnectionUriWithMaxPoolSize = MongoDbConnectionUri() + "&maxPoolSize=50"  + "&WTimeoutMS=2500";

        public static string MongoDbConnectionUri()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            return configuration.GetValue<string>("MongoUri");

        }
    }
}
