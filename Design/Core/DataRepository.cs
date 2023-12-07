using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Collections.ObjectModel;

namespace Design.Core
{
    public class DataRepository : IDisposable
    {
        private VegDbContext _dbContext;

        public DataRepository(VegDbContext dbContext) => _dbContext = dbContext;

        public IEnumerable<TModel> GetData<TModel>() where TModel : class
            => _dbContext.Set<TModel>();

        public void AddOrUpdate<TModel>(TModel entity) where TModel : class
        {
            _dbContext.Set<TModel>().AddOrUpdate(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteData<TModel>(TModel entity) where TModel : class
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }

        public void Dispose() => _dbContext.Dispose();
    }
}