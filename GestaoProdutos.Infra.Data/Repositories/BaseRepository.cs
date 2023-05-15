using GestaoProdutos.Domain.Core;
using GestaoProdutos.Domain.Interfaces;
using GestaoProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Repositories
{
    public class BaseRepository<TModel, TKey> : IBaseRepository<TModel, TKey>
        where TModel : class
    {
        private readonly DataContext _dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(TModel model)
        {
            _dataContext?.Add(model);
        }

        public void Update(TModel model)
        {
            _dataContext?.Update(model);
        }

        public void Delete(TModel model)
        {
            _dataContext?.Remove(model);
        }

        public List<TModel> GetAll()
        {
            return _dataContext?.Set<TModel>().ToList();
        }

        public List<TModel> GetAll(Func<TModel, bool> where)
        {
            return _dataContext?.Set<TModel>().Where(where).ToList();
        }

        public TModel Get(Func<TModel, bool> where)
        {
            return _dataContext?.Set<TModel>().FirstOrDefault(where);
        }

        public TModel GetById(TKey id)
        {
            return _dataContext?.Set<TModel>().Find(id);
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
