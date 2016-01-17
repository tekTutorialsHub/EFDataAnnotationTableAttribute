using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFDataAnnotationTableAttribute
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseAlways<EFContext>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer1> Customer1 { get; set; }
        public DbSet<Customer2> Customer2 { get; set; }
    }


}
