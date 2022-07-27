using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Models
{
   public class ProductModel
    {
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public string DescriptionEN { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public decimal AvailableSTK { get; set; }
        public decimal Vat { get; set; }
        public bool Inactive { get; set; }
        public int ComponentType { get; set; }
        public int RemoteId { get; set; }

    }
}
