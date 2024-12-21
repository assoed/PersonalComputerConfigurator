using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PersonalComputerConfigurator.Models
{
    public partial class PCConfiguratorModel : DbContext
    {
        public PCConfiguratorModel()
            : base("name=PCConfiguratorDB")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<userRole> userRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.middleName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<userRole>()
                .Property(e => e.roleName)
                .IsUnicode(false);

            modelBuilder.Entity<userRole>()
                .HasMany(e => e.user)
                .WithOptional(e => e.userRole)
                .HasForeignKey(e => e.role);
        }
    }
}
