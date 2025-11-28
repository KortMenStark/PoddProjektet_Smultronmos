using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models_new
{
    public class Kategori
    {
        //MongoDB-ID lagras som ObjectId i databasen men hanteras som string i koden.
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Namn { get; set; }
    }
}