using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork
    {
        public UcastniciContext Context { get; private set; }
        
        public UnitOfWork()
        {
            Context = new UcastniciContext();
        }

        public UnitOfWork(UcastniciContext context)
        {
            Context = context;
        }
   
        public int Save()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
