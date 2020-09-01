using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReactChat.Data
{
    public class DBContext
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;
        public IConfigurationRoot Configuration { get; }

        public DBContext()
        {
            Configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            mongoClient = new MongoClient(Configuration["MongoDBConnectString:ConnectionString"]);
            database = mongoClient.GetDatabase(Configuration["MongoDBConnectString:Database"]);
        }
    }
  
}
