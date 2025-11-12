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
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FeedUrl { get; set; }

        public string CategoryId { get; set; } // Koppling till kategori

        public List<string> EpisodeIds { get; set; } = new List<string>(); // Lista med avsnitt
    }
}
