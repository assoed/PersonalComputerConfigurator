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
        public virtual DbSet<gpu> gpu { get; set; }
        public virtual DbSet<hdd> hdd { get; set; }
        public virtual DbSet<motherboards> motherboards { get; set; }
        public virtual DbSet<processors> processors { get; set; }
        public virtual DbSet<psu> psu { get; set; }
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

            modelBuilder.Entity<cases>()
                .Property(e => e.price)
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
                .Property(e => e.power)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.material)
                .IsUnicode(false);

            modelBuilder.Entity<coolers>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<gpu>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.gpuFrequency)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.gpuBoost)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.memorySize)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.memoryType)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<gpu>()
                .Property(e => e.tdp)
                .IsUnicode(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<hdd>()
                .Property(e => e.price)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.powerSupply)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.formFactor)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.certificate)
                .IsUnicode(false);

            modelBuilder.Entity<psu>()
                .Property(e => e.price)
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
