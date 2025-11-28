using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models_new
{
    public class Avsnitt
    {
        //MongoDB-ID lagras som ObjectId i databasen men hanteras som string i koden.
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? PoddId { get; set; }
        public string? Titel { get; set; }
        public DateTime PubliceringsDatum { get; set; }
        public string? Sammanfattning { get; set; }
    }
}