using DAL.Interfaces;
using Models_new;
using System.ServiceModel.Syndication;

namespace BL
{
    public class PoddService
    {
        private readonly IPoddRepository poddRepository;

        public PoddService(IPoddRepository poddRepository)
        {
            this.poddRepository = poddRepository;
        }

        public async Task<List<Podd>> HamtaAllaPoddar()
        {
            return await poddRepository.HamtaAlla();
        }

        public async Task<Podd> HamtaPoddMedId(string poddId)
        {
            return await poddRepository.HamtaEnPodd(poddId);
        }

        public async Task UppdateraPodd(Podd uppdateradPodd)
        {
            await poddRepository.UppdateraPodd(uppdateradPodd);
        }

        public async Task TaBortPodd(string poddId)
        {
            await poddRepository.TaBortPodd(poddId);
        }

        //Här skapas ett Poddflöde från ett SyndicationFeed.
        public Poddflode SkapaPoddflode(SyndicationFeed ettFeed)
        {
            // Skapa ett nytt Poddflode-objekt som ska fyllas med info från RSS.
            var poddflode = new Poddflode();


            //Hämtar titel, beskrivning och bild-URL från RSS-feeden.
            //Om någon av dessa saknas i RSS-feeden, sätts en standardtext eller tom sträng.
            poddflode.Titel = ettFeed.Title.Text ?? "Det finns ingen titel.";
            poddflode.Beskrivning = ettFeed.Description?.Text ?? "Det finns ingen beskrivning.";

            // Returnerar det ifyllda Poddflödet.
            return poddflode;
        }

        public async Task SparaPodd(Poddflode ettFlode, string rssUrl, string kategoriId)
        {

            //Här skapas ett nytt Podd-objekt med information från Poddflödet och andra parametrar.
            var nyPodd = new Podd
            {
                Titel = ettFlode.Titel,
                Beskrivning = ettFlode.Beskrivning,
                RssUrl = rssUrl,
                KategoriId = kategoriId
            };

            //Anropar repository-metoden för att spara den nya podden i databasen.
            await poddRepository.LagraPodd(nyPodd);
        }

        public async Task<bool> SparaPoddOmNyAsync(Poddflode ettFlode, string rssUrl, string kategoriId)
        {
            //Kontrollerar om en podd med samma RSS-URL redan finns i databasen.
            bool poddFinns = await poddRepository.HittaPoddMedUrlAsync(rssUrl);
            if (poddFinns)
            {
                //Om podden redan finns, returneras false.
                return false;
            }
            else
            {
                //Om podden inte finns, sparas den och true returneras.
                await SparaPodd(ettFlode, rssUrl, kategoriId);
                return true;
            }
        }
    }
}
