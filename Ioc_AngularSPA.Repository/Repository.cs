using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core;
using Ioc_AngularSPA.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Collections;
using System.Linq.Expressions;

namespace Ioc_AngularSPA.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context = null;
        protected DbSet<T> DbSet;
        //public Repository()
        //{
        //    DbSet = new DbSet<T>();
        //}
        public Repository()
        {

        }
        public Repository(DbContext dataContext)
        {
            this.context = dataContext;

            DbSet = dataContext.Set<T>();
        }

        #region IRepository<T> Members

        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        //public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        //{
        //    return DbSet.Where(predicate);
        //}

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(long id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        

        #endregion
    }
}
