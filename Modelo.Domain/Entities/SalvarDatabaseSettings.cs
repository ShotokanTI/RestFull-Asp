using Modelo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Entities
{
    public class SalvarDatabaseSettings : ISalvarDatabaseSettings
    {
        public string ProdutosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
