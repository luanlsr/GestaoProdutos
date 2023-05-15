using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Core.Entities
{
    public class Product : IEntity
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set;}
        public Guid? StockId { get; set; }
        public Guid? CategoryId { get; set; }
        public Category Category { get; set; }
        public Stock Stock { get; set; }
    }
}
