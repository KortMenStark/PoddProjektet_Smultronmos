using DAL.Interfaces;
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
    public class AvsnittRepository : IAvsnittRepository
    {
        //Skapar en referens till avsnittkollektionen i MongoDB-databasen.
        private readonly IMongoCollection<Avsnitt> avsnittKollektion;

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till avsnittkollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public AvsnittRepository(MongoDbContext context)
        {
            avsnittKollektion = context.AvsnittKollektion;
        }
        public async Task<List<Avsnitt>> HamtaAlla()
        {
            var filter = Builders<Avsnitt>.Filter.Empty;
            var avsnitt = await avsnittKollektion.Find(filter).ToListAsync();
            return avsnitt;
        }
        public async Task<Avsnitt> HamtaEttAvsnitt(string avsnittId)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, avsnittId);
            return await avsnittKollektion.Find(filter).FirstOrDefaultAsync();
        }
        public async Task LagraAvsnitt(Avsnitt nyttAvsnitt)
        {
            await avsnittKollektion.InsertOneAsync(nyttAvsnitt);
        }
        public async Task UppdateraAvsnitt(Avsnitt uppdateratAvsnitt)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, uppdateratAvsnitt.Id);
            await avsnittKollektion.ReplaceOneAsync(filter, uppdateratAvsnitt);
        }
        public async Task TaBortAvsnitt(string avsnittId)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, avsnittId);
            await avsnittKollektion.DeleteOneAsync(filter);
        }
    }
}