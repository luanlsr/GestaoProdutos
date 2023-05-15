using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Interfaces.Categories.Repository;
using GestaoProdutos.Domain.Interfaces.Products.Repository;
using GestaoProdutos.Domain.Interfaces.Stocks.Repository;
using GestaoProdutos.Infra.Data.Contexts;
using GestaoProdutos.Infra.Data.Repositories.Categories;
using GestaoProdutos.Infra.Data.Repositories.Products;
using GestaoProdutos.Infra.Data.Repositories.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IProductRepository? ProductRepository => new ProductRepository(_dataContext);

        public ICategoryRepository? CategoryRepository => new CategoryRepository(_dataContext);

        public IStockRepository? StockRepository => new StockRepository(_dataContext);

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }
    }
}
