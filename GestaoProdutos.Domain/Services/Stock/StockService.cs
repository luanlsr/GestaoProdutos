using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Interfaces.Stocks.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Services.Stock
{
    public class StockService : IStockService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StockService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Core.Entities.Stock model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Core.Entities.Stock model)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Stock Get(Func<Core.Entities.Stock, bool> where)
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Stock> GetAll(Func<Core.Entities.Stock, bool> where)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Stock GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Entities.Stock model)
        {
            throw new NotImplementedException();
        }
    }
}
