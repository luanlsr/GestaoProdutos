using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Interfaces.Products.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Core.Entities.Product model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Core.Entities.Product model)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Product Get(Func<Core.Entities.Product, bool> where)
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Product> GetAll(Func<Core.Entities.Product, bool> where)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Entities.Product model)
        {
            throw new NotImplementedException();
        }
    }
}
