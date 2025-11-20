using DAL.Interfaces;
using Models_new;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public async Task LagraNyPodd(Podd nyPodd)
        {
            await poddRepository.LagraPodd(nyPodd);
        }

        public async Task UppdateraPodd(Podd uppdateradPodd)
        {
            await poddRepository.UppdateraPodd(uppdateradPodd);
        }

        public async Task TaBortPodd(string poddId)
        {
            await poddRepository.TaBortPodd(poddId);
        }

        public Poddflode SkapaPoddflode(SyndicationFeed ettFeed)
        {
            var poddflode = new Poddflode();

            poddflode.Titel = ettFeed.Title.Text ?? "Det finns ingen titel.";
            poddflode.Beskrivning = ettFeed.Description?.Text ?? "Det finns ingen beskrivning.";
            poddflode.BildUrl = ettFeed.ImageUrl?.ToString() ?? "";

            foreach (var item in ettFeed.Items)
            {
                var avsnitt = new Avsnitt
                {
                    Titel = item.Title.Text ?? "Det finns ingen titel.",
                    Sammanfattning = item.Summary?.Text ?? "Det finns ingen sammanfattning.",
                    PubliceringsDatum = item.PublishDate.DateTime
                };
                poddflode.AvsnittLista.Add(avsnitt);
            }
            return poddflode;
        }

        public async Task SparaPodd(Poddflode ettFlode, string rssUrl, string kategoriId)
        {
            var nyPodd = new Podd
            {
                Titel = ettFlode.Titel,
                Beskrivning = ettFlode.Beskrivning,
                RssUrl = rssUrl,
                KategoriId = kategoriId
            };
            await poddRepository.LagraPodd(nyPodd);
        }

        public async Task<bool> SparaPoddOmNyAsync(Poddflode ettFlode, string rssUrl, string kategoriId)
        {
            bool poddFinns = await poddRepository.HittaPoddMedUrlAsync(rssUrl);
            if (poddFinns)
            {
                return false;
            }
            else
            {
                await SparaPodd(ettFlode, rssUrl, kategoriId);
                return true;
            }
        }
    }
}
