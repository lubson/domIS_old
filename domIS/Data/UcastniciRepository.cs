using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class UcastniciRepository : IUcastniciRepository<Ucastnik>
    {
        private readonly UnitOfWork _uow;

        public UcastniciRepository() 
        { 
            _uow = new UnitOfWork();
        }
        
        public UcastniciRepository(UnitOfWork uow)
        {
            _uow = uow;
        }

        public IEnumerable<Ucastnik> GetAll()
        {
 	        throw new NotImplementedException();
        }

        public IEnumerable<Ucastnik> FindBy(System.Linq.Expressions.Expression<Func<Ucastnik,bool>> predicate)
        {
 	        throw new NotImplementedException();
        }

        public void InsertOrUpdate(Ucastnik ucastnik)
        {
            if (ucastnik.UcastnikId == -1)
            {
                var ucast = new Ucastnik();
                _uow.Context.Set<Ucastnik>().Add(ucast);
            }
        }

        public void Delete(Ucastnik ucastnik)
        {
 	        throw new NotImplementedException();
        }

        public void Edit(Ucastnik ucastnik)
        {
 	        throw new NotImplementedException();
        }
    }
}