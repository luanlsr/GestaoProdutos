using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Interfaces.Categories.Repository;
using GestaoProdutos.Domain.Interfaces.Products.Repository;
using GestaoProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Repositories.Categories
{
    public class CategoryRepository : BaseRepository<Category, Guid>, ICategoryRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
