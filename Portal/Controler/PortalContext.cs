using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{
    public class PortalContext:DbContext
    {
        //Data Source = DESKTOP - HE5C4RQ\SQLEXPRESS;Initial Catalog = Portal; Integrated Security = True
        public PortalContext() : base(@"Data Source = DESKTOP - HE5C4RQ\SQLEXPRESS;Initial Catalog = Portal; Integrated Security = True")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<TransAction> TransActions { get; set; }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
