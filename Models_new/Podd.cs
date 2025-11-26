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
        //MongoDB-ID lagras som ObjectId i databasen men hanteras som string i koden.
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Titel { get; set; }
        public string? Beskrivning { get; set; }
        public string? RssUrl { get; set; }
        public string? KategoriId { get; set; }


        //Denna metod gör att poddens Titel visas i t.ex. en lista istället för "Models_new.Podd".
        //Den visar 0 referenser eftersom ToStrin()
        //anropas implicit av .NET när ett objekt ska representeras som en sträng.
        public override string? ToString()
        {
            return Titel;
        }
    }
}