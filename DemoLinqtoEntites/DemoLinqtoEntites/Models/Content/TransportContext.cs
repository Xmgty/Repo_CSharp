using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DemoLinqtoEntites.Models.Entities;

namespace DemoLinqtoEntites.Models.Content
{
    public class TransportContext : DbContext
    {
        public TransportContext()
            :base("TransportDb")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new InitializerCustom());
        }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<RouteInfo> Routes { get; set; }
        public DbSet<StopInfo> Stopes { get; set; }
        public DbSet<RoadtoStop> RoadtoStopes { get; set; }
    }
}
