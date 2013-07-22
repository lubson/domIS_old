using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
using System.Configuration;

namespace Data
{
    public class UcastniciContext : DbContext
    {
        public UcastniciContext() : base("Data Source=|DataDirectory|\\developDB.sdf") { }

        public DbSet<Ucastnik> Ucastnici { get; set; }
    }
}
