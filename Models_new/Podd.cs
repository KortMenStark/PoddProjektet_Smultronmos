using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models_new
{
    public class Podd
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Titel { get; set; }
        public string? Beskrivning { get; set; }
        public string? RssUrl { get; set; }
        public string? KategoriId { get; set; }

        public override string? ToString()
        {
            return Titel;
        }
    }
}