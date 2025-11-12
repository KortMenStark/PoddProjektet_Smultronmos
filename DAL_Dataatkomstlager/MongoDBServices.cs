using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace DAL_Dataatkomstlager
{
    public class MongoDBServices
    {
        private readonly IMongoCollection<Podcast> poddCollection;

        public MongoDBServices() 
        { 
        var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:1995@orumongodb.ktcd6cz.mongodb.net/?appName=OruMongoDB");
        var databas = klient.GetDatabase("OruMongoDB");
            poddCollection = databas.GetCollection<Podcast>("Poddar");
        }
    }
}
