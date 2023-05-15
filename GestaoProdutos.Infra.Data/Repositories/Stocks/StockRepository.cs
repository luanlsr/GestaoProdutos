using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Interfaces.Stocks.Repository;
using GestaoProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Repositories.Stocks
{
    public class StockRepository : BaseRepository<Stock, Guid>, IStockRepository
    {
        private readonly DataContext _dataContext;

        public StockRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
