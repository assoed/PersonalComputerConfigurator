using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PersonalComputerConfigurator.Models
{
    public partial class PCConfiguratorModel : DbContext
    {
        public PCConfiguratorModel()
            : base("name=PCConfiguratorModel")
        {
        }

        public virtual DbSet<cases> cases { get; set; }
        public virtual DbSet<coolers> coolers { get; set; }
        public virtual DbSet<hdd> hdd { get; set; }
        public virtual DbSet<motherboards> motherboards { get; set; }
        public virtual DbSet<processors> processors { get; set; }
        public virtual DbSet<ram> ram { get; set; }
        public virtual DbSet<ssd> ssd { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<userRole> userRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cases>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<cases>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<cases>()
                .Property(e => e.formFaktor)
                .IsUnicode(false);

            modelBuilder.Entity<cases>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.socket)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ssd>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ssd>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ssd>()
                .Property(e => e.capacity)
                .IsFixedLength();

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

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
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
