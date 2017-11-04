using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc_AngularSPA.Core;
using System.Collections;
using System.Linq.Expressions;

namespace Ioc_AngularSPA.Repo
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        T GetById(long id);
    }
}
