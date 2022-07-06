using Microsoft.EntityFrameworkCore;
using Permission.Domain;
using Permission.Persistence.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Permission.Persistence.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options) : base(options) { 
        
        
        }
             
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<PermissionTypes> PermissionTypes { get; set; }

      

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Permission");
           ModelConfig(builder);
            //DbContext
        }

        private  void ModelConfig(ModelBuilder modelBuilder)
        {
            new PermissionConfiguration(modelBuilder.Entity<Permissions>());
            new PermissionTypesConfiguration(modelBuilder.Entity<PermissionTypes>());

        }
    }
}
