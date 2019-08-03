using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBRepository.Domain
{
    [BsonIgnoreExtraElements]
    public sealed class Aluno
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
    }
}
