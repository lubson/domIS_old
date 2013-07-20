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


        public UcastnikRepository() : base()
        { }

        public UcastnikRepository(UcastniciUnitOfWork uow) : base(uow)
        { }
    }
}
