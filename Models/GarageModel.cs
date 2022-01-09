using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GarageAppWeb.Models
{
    public partial class GarageModel : DbContext
    {
        public GarageModel()
            : base("name=GarageModel")
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
