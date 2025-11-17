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

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till poddkollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public PoddRepository(MongoDbContext context)
        {
            poddKollektion = context.poddKollektion;
        }

        public async Task<bool> PoddFinnsAsync(string rssUrl)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.RssUrl, rssUrl);
            return await poddKollektion.Find(filter).AnyAsync();
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

        public async Task LagraPodd(Podd nyPodd)
        {
            await poddKollektion.InsertOneAsync(nyPodd);
        }

        public async Task UppdateraPodd(Podd uppdateradPodd)
        {
            var filter = Builders<Podd>.Filter.Eq(p => p.Id, uppdateradPodd.Id);
            await poddKollektion.ReplaceOneAsync(filter, uppdateradPodd);
        }
    }
}