using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Core.Entities
{
    public class Category : IEntity
    {
        public Guid? Id { get; set; }
        public string? Description { get; set; }
    }
}
