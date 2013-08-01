using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Data
{
    public interface IUcastniciRepository<Ucastnik>
    {
        IEnumerable<Ucastnik> GetAll();
        IEnumerable<Ucastnik> FindBy(Expression<Func<Ucastnik, bool>> predicate);
        void InsertOrUpdate(Ucastnik entity);
        void Delete(Ucastnik entity);
    }
}

    
    