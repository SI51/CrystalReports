using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CrystalReports.Clases
{
    class DataModel:DbContext
    {
       
        public virtual DbSet<Productos> productos { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DataModel() : base("DataModel")
        {

        }
    }
}
