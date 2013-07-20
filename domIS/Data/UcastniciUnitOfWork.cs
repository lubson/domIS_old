using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UcastniciUnitOfWork
    {
        private readonly UcastniciContext _context;


        public UcastniciUnitOfWork()
        {
            _context = new UcastniciContext();
        }

        public UcastniciUnitOfWork(UcastniciContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public UcastniciContext Context
        {
            get { return _context; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
