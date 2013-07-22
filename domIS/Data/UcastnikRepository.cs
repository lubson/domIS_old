using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{

    public class UcastnikRepository : Repository<Ucastnik>
    {


        public UcastnikRepository()
        {
            UnitOfWork = new UcastniciUnitOfWork();
        }

        public UcastnikRepository(UcastniciUnitOfWork uow) : base(uow)
        {
            UnitOfWork = uow;
        }
    }
}
