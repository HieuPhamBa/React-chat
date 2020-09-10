using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReactChat.Data
{
   

    public abstract class MongoContext 
    {
        protected MongoContext(IMongoDBSettings connectionSetting)
        {
            var client = new MongoClient(connectionSetting.ConnectionString);
            Database = client.GetDatabase(connectionSetting.DatabaseName);
        }

        public IMongoDatabase Database { get; }
    }
}
