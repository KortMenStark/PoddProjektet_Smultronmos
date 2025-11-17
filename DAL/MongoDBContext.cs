using Models;
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
        public IMongoCollection<Podd> poddKollektion { get; }
        public IMongoCollection<Kategori> kategoriKollektion { get; }
        public IMongoCollection<Avsnitt> avsnittKollektion { get; }


        //Anslutning till MongoDB-databasen.
        public MongoDbContext()
        {
            var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:1995@orumongodb.ktcd6cz.mongodb.net/?appName=OruMongoDB");
            var databas = klient.GetDatabase("OruMongoDB");
            poddKollektion = databas.GetCollection<Podd>("Poddar");
        }
    }
}