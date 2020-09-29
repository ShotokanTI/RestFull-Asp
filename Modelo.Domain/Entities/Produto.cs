using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Domain.Entities
{
    public class Produto
    {
        public static List<Produto> produtoList { get; set; }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        [BsonElement("Nome")]
        [JsonProperty("Nome")]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public string Categoria { get; set; }

        public string Preco { get; set; }

        public string Marca { get; set; }

        public string Codigo { get; set; }

    }
}
