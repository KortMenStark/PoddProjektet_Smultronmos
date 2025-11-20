using Models_new;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MongoDbContext
    {
        //Skapar kollektioner för Podd, Kategori och Avsnitt.
        public IMongoCollection<Podd> PoddKollektion { get; }
        public IMongoCollection<Kategori> KategoriKollektion { get; }
        public IMongoCollection<Avsnitt> AvsnittKollektion { get; }


        //Anslutning till MongoDB-databasen.
        public MongoDbContext()
        {
            var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:1995@orumongodb.ktcd6cz.mongodb.net/?appName=OruMongoDB");
            var database = klient.GetDatabase("OruMongoDB");

            PoddKollektion = database.GetCollection<Podd>("Poddar");
            KategoriKollektion = database.GetCollection<Kategori>("Kategorier");
            AvsnittKollektion = database.GetCollection<Avsnitt>("Avsnitt");
        }
    }
}