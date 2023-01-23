using CrowdFundingDAL.GestionEntity.context;
using CrowdFundingDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdFundingDAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DataContext _Context;

        public BaseRepository(DataContext context)
        {
            _Context = context;

        }
        public bool Delete(TEntity entity)
        {
            _Context.Remove(entity);
            return _Context.SaveChanges() > 0;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>();

            
        }

        public TEntity? GetById(params object[] Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        public TEntity Insert(TEntity entity)
        {
            _Context.Add(entity);
            _Context.SaveChanges();
            return entity;
        }

        public bool Update(TEntity entity)
        {
            _Context.Update(entity);
            return _Context.SaveChanges() > 0;
        }
    }
}
