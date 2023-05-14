using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Domain.Interfaces.Categories.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Domain.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Core.Entities.Category model)
        {
            _unitOfWork.CategoryRepository.Add(model);
        }

        public void Delete(Core.Entities.Category model)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Category Get(Func<Core.Entities.Category, bool> where)
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Core.Entities.Category> GetAll(Func<Core.Entities.Category, bool> where)
        {
            throw new NotImplementedException();
        }

        public Core.Entities.Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Core.Entities.Category model)
        {
            throw new NotImplementedException();
        }
    }
}
