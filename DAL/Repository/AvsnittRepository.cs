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
    //Ärver från IAvsnittRepository för att implementera dess metoder.
    public class AvsnittRepository : IAvsnittRepository
    {
        //Skapar en referens till avsnittkollektionen i MongoDB-databasen.
        private readonly IMongoCollection<Avsnitt> avsnittKollektion;

        private readonly MongoDbContext context;

        //Detta kallas Dependency Injection. Vi skickar in en instans av MongoDbContext för att få tillgång till avsnittkollektionen.
        //Detta för att slippa behöva koppla ihop alla repositoryklasseerna till databasen varje gång.
        public AvsnittRepository(MongoDbContext context)
        {
            this.context = context;
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

        //Transaktioner används för att säkerställa att alla operationer inom transaktionen
        //antingen lyckas eller misslyckas tillsammans.
        public async Task LagraAvsnitt(Avsnitt nyttAvsnitt)
        {
            //Startar en ny databas-session och "aktiverar" transaktionshantering.
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                //Försöker lägga till det nya avsnittet i kollektionen i databasen inom transaktionen.
                await avsnittKollektion.InsertOneAsync(session, nyttAvsnitt);

                //Om allt gick bra, "commitar" vi transaktionen för att spara ändringarna permanent.
                await session.CommitTransactionAsync();
            }
            catch
            {
                //Om något gick fel, "abortar" vi transaktionen för att rulla tillbaka alla ändringar.
                await session.AbortTransactionAsync();
                throw;
            }
        }
        public async Task UppdateraAvsnitt(Avsnitt uppdateratAvsnitt)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, uppdateratAvsnitt.Id);

            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await avsnittKollektion.ReplaceOneAsync(session, filter, uppdateratAvsnitt);
                await session.CommitTransactionAsync();
            }
            catch
            {
                await session.AbortTransactionAsync();
                throw;
            }
        }
        public async Task TaBortAvsnitt(string avsnittId)
        {
            var filter = Builders<Avsnitt>.Filter.Eq(a => a.Id, avsnittId);

            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await avsnittKollektion.DeleteOneAsync(session, filter);
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