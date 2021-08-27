using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Code_First
{
    class MyDbContext :DbContext
    {
        public MyDbContext() : base("name=MDSConString") 
        {
            Database.SetInitializer<MyDbContext>(new CreateDatabaseIfNotExists<MyDbContext>());

            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());

            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseAlways<MyDbContext>());

        }

        public virtual DbSet<Broker> Brokers { get; set; }

        
    }
}
