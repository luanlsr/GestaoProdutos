using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Interfaces.Products.Repository;
using GestaoProdutos.Domain.Interfaces.Stocks.Repository;
using GestaoProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Repositories.Products
{
    public class ProductRepository : BaseRepository<Product, Guid>, IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
