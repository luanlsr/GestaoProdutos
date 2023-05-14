using GestaoProdutos.Domain.Interfaces.Categories.Repository;
using GestaoProdutos.Domain.Interfaces.Products.Repository;
using GestaoProdutos.Domain.Interfaces.Stocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository? ProductRepository { get; }
        ICategoryRepository? CategoryRepository { get; }
        IStockRepository? StockRepository { get; }
        void SaveChanges();
    }
}
