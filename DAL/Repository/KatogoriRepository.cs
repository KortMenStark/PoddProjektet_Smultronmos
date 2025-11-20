using DAL.Interfaces;
using Models_new;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KategoriRepository : IKategoriRepository
    {
        //Skapar en referens till kategorikollektionen i MongoDB-databasen.
        private readonly IMongoCollection<Kategori> kategoriKollektion;

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till kategorikollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public KategoriRepository(MongoDbContext context)
        {
            kategoriKollektion = context.KategoriKollektion;
        }

        public async Task<List<Kategori>> HamtaAlla()
        {
            var filter = Builders<Kategori>.Filter.Empty;
            var kategorier = await kategoriKollektion.Find(filter).ToListAsync();
            return kategorier;
        }

        public async Task<Kategori> HamtaEnKategori(string kategoriId)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategoriId);
            return await kategoriKollektion.Find(filter).FirstOrDefaultAsync();
        }

        public async Task LagraKategori(Kategori nyKategori)
        {
            await kategoriKollektion.InsertOneAsync(nyKategori);
        }

        public async Task Uppdaterakategori(Kategori uppdateradKategori)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, uppdateradKategori.Id);
            await kategoriKollektion.ReplaceOneAsync(filter, uppdateradKategori);
        }

        public async Task TaBortkategori(string kategoriId)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategoriId);
            await kategoriKollektion.DeleteOneAsync(filter);
        }
    }
}