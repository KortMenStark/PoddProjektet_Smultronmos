using DAL.Interfaces;
using Models_new;
using MongoDB.Driver;

namespace DAL.Repository
{
    //Ärver från IKategoriRepository för att implementera dess metoder.
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

        public async Task<Kategori> HamtaEnKategori(string kategoriId)
        {
            var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategoriId);
            return await kategoriKollektion.Find(filter).FirstOrDefaultAsync();
        }

        //Transaktioner används för att säkerställa att alla operationer inom transaktionen
        //antingen lyckas eller misslyckas tillsammans.
        public async Task LagraNyKategori(Kategori nyKategori)
        {
            //Startar en ny databas-session och "aktiverar" transaktionshantering.
            using var session = await context.MongoKlient.StartSessionAsync();
            session.StartTransaction();

            try
            {
                //Försöker lägga till den nya kategorin i kollektionen i databasen inom transaktionen.
                await kategoriKollektion.InsertOneAsync(session, nyKategori);

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

        public async Task UppdateraKategori(Kategori uppdateradKategori)
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

        public async Task TaBortKategori(string kategoriId)
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

        public async Task<List<Kategori>> HamtaAllaKategorier()
        {
            var alla = await kategoriKollektion.Find(_ => true).ToListAsync();
            return alla;
        }
    }
}