using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    
    public class UcastnikRepository
    {
        UcastniciContext _context;

        public UcastnikRepository(UcastniciContext context)
        {
            _context = context;
        }

        public void Add(Ucastnik ucastnik)
        {
            _context.Ucastnici.Add(ucastnik);
            _context.SaveChanges();
        }
    }
}
