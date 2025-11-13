using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL_Dataatkomstlager;
using System.ServiceModel.Syndication;
using System.Xml;

namespace BL_Affarslager
{
    public class PodcastService
    {
        private readonly PodcastRepository repository;

        public PodcastService()
        {
            repository = new PodcastRepository();
        }

        public List<Podcast> HamtaAlla()
        {
            return repository.GetAll();
        }

        public void LaggTill(Podcast podcast)
        {
            // Här kan du lägga validering om du vill
            repository.Insert(podcast);
        }

        public void Uppdatera(Podcast podcast)
        {
            repository.Update(podcast);
        }

        public void TaBort(string id)
        {
            repository.Delete(id);
        }
        public Podcast SkapaPodcastFranUrl(string feedUrl)
        {
            Podcast podcast = LasPodcastFranRss(feedUrl);
            repository.Insert(podcast);
            return podcast;
        }

        // Denna metod gör EN sak: läser RSS och bygger ett Podcast-objekt
        // Läser RSS och bygger ett Podcast-objekt (ingen databas här)
        private Podcast LasPodcastFranRss(string feedUrl)
        {
            // "Gammal" using-syntax som funkar i alla C#-versioner
            using (XmlReader reader = XmlReader.Create(feedUrl))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);

                Podcast podcast = new Podcast();
                podcast.Id = Guid.NewGuid().ToString();
                podcast.FeedUrl = feedUrl;

                if (feed.Title != null)
                {
                    podcast.Title = feed.Title.Text;
                }

                if (feed.Description != null)
                {
                    podcast.Description = feed.Description.Text;
                }

                // Enkel kategori (tar första om det finns)
                if (feed.Categories.Any())
                {
                    podcast.CategoryId = feed.Categories.First().Name;
                }

                // Enkel bild (om feeden har en bild)
                if (feed.ImageUrl != null)
                {
                    podcast.ImageUrl = feed.ImageUrl.ToString();
                }

                return podcast;
            }
        }
    }
}
