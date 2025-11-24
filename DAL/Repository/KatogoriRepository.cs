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

        private readonly MongoDbContext context;

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till kategorikollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public KategoriRepository(MongoDbContext context)
        {
            this.context = context;
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
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriKollektion.InsertOneAsync(session, nyKategori);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        public async Task Uppdaterakategori(Kategori uppdateradKategori)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, uppdateradKategori.Id);
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriKollektion.ReplaceOneAsync(session, filter, uppdateradKategori);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        public async Task TaBortkategori(string kategoriId)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategoriId);
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await kategoriKollektion.DeleteOneAsync(session, filter);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }
    }
}