using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriParkProje.Data.Concrete.Models;

namespace VeriParkProje.Data.Concrete.Context
{
    public class VeriParkDbContext: DbContext
    {
        public VeriParkDbContext() : base("name = WebAppCon")
        {

            Database.SetInitializer<VeriParkDbContext>(null);
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }
        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<SpecialDay> SpecialDays { get; set; }
    }
}
