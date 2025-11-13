using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Podcast
    {
        [BsonId] // valfritt, men bra eftersom vi kör via MongoDB
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string FeedUrl { get; set; }

        public string CategoryId { get; set; }  // Koppling till kategori

        public string ImageUrl { get; set; }    // Omslagsbild till PictureBox

        public List<string> EpisodeIds { get; set; } = new List<string>(); // Lista med avsnitt
    }
}
