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
    public class PoddRepository : IPoddRepository
    {
        //Skapar en referens till poddkollektionen i MongoDB-databasen.
        private readonly IMongoCollection<Podd> poddKollektion;

        private readonly MongoDbContext context;

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till poddkollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public PoddRepository(MongoDbContext context)
        {
            this.context = context;
            poddKollektion = context.PoddKollektion;
        }

        public async Task<List<Podd>> HamtaAlla()
        {
            var filter = Builders<Podd>.Filter.Empty;
            var poddar = await poddKollektion.Find(filter).ToListAsync();
            return poddar;
        }

        public async Task<Podd> HamtaEnPodd(string poddId)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, poddId);
            return await poddKollektion.Find(filter).FirstOrDefaultAsync();
        }

        //Transaktioner används för att säkerställa att alla operationer inom transaktionen
        //antingen lyckas eller misslyckas tillsammans.
        public async Task LagraPodd(Podd nyPodd)
        {
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await poddKollektion.InsertOneAsync(session, nyPodd);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        public async Task UppdateraPodd(Podd uppdateradPodd)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, uppdateradPodd.Id);
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await poddKollektion.ReplaceOneAsync(session, filter, uppdateradPodd);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }
        public async Task TaBortPodd(string poddId)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, poddId);

            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await poddKollektion.DeleteOneAsync(session, filter);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }

        public async Task<bool> HittaPoddMedUrlAsync(string rssUrl)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.RssUrl, rssUrl);
            return await poddKollektion.Find(filter).AnyAsync();
        }

    }
}