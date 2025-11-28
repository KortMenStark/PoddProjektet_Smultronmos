using Models_new;
using MongoDB.Driver;

namespace DAL
{
    public class MongoDbContext
    {
        //Skapar kollektioner för Podd, Kategori och Avsnitt.
        public IMongoCollection<Podd> PoddKollektion { get; }
        public IMongoCollection<Kategori> KategoriKollektion { get; }
        public IMongoCollection<Avsnitt> AvsnittKollektion { get; }

        public MongoClient MongoKlient { get; }


        //Anslutning till MongoDB-databasen.
        public MongoDbContext()
        {
            MongoKlient = new MongoClient("mongodb+srv://OruMongoDBAdmin:1995@orumongodb.ktcd6cz.mongodb.net/?appName=OruMongoDB");
            var database = MongoKlient.GetDatabase("OruMongoDB");

            PoddKollektion = database.GetCollection<Podd>("Poddar");
            KategoriKollektion = database.GetCollection<Kategori>("Kategorier");
            AvsnittKollektion = database.GetCollection<Avsnitt>("Avsnitt");
        }
    }
}