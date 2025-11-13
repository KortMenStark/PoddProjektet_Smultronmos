using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace DAL_Dataatkomstlager
{
    public class PodcastRepository
    {
        private readonly IMongoCollection<Podcast> podcastCollection;

        public PodcastRepository()
        {
            // Anpassa efter din connection string/databasnamn
            var client = new MongoClient("mongodb+srv://OruMongoDBAdmin:1995@orumongodb.ktcd6cz.mongodb.net/?appName=OruMongoDB");
            var database = client.GetDatabase("OruMongoDB");
            podcastCollection = database.GetCollection<Podcast>("Podcasts");
        }

        public List<Podcast> GetAll()
        {
            return podcastCollection.Find(Builders<Podcast>.Filter.Empty).ToList();
        }

        public Podcast GetById(string id)
        {
            return podcastCollection.Find(p => p.Id == id).FirstOrDefault();
        }

        public void Insert(Podcast podcast)
        {
            podcastCollection.InsertOne(podcast);
        }

        public void Update(Podcast podcast)
        {
            podcastCollection.ReplaceOne(p => p.Id == podcast.Id, podcast);
        }

        public void Delete(string id)
        {
            podcastCollection.DeleteOne(p => p.Id == id);
        }
    }
}
