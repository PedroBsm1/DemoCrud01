using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace dal
{
    public class Agenda
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } 
        public string Nome { get; set; } = String.Empty;

        public string Endereco { get; set; } = String.Empty;

        public string Telefone { get; set; } = String.Empty;
    }
}