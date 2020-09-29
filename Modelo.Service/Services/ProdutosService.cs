using Domain.Entities;
using Modelo.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modelo.Service.Services
{
    public class ProdutosService
    {
        private readonly IMongoCollection<Produto> _Produtos;

        public ProdutosService(ISalvarDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _Produtos = database.GetCollection<Produto>(settings.ProdutosCollectionName);
        }

        public List<Produto> Get() =>
            _Produtos.Find(Produtos => true).ToList();

        public Produto Get(string id) =>

            _Produtos.Find<Produto>(Produtos => Produtos.Codigo == id || Produtos.Marca == id || Produtos.Nome == id || Produtos.Id == id).FirstOrDefault();

        public Produto Create(Produto Produtos)
        {
            _Produtos.InsertOne(Produtos);
            return Produtos;
        }

        public void Update(string id, Produto ProdutosIn) =>
            _Produtos.ReplaceOne(ProdutosIn => ProdutosIn.Id == id, ProdutosIn);

        public void Remove(Produto ProdutosIn) =>
            _Produtos.DeleteOne(Produtos => Produtos.Id == ProdutosIn.Id);

        public void Remove(string id) =>
            _Produtos.DeleteOne(Produtos => Produtos.Id == id);
    }
}

