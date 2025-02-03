using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PersonalComputerConfigurator.Models
{
    public partial class PCConfiguratorModel : DbContext
    {
        public PCConfiguratorModel()
            : base("name=PersonalComputerConfiguratorModel")
        {
        }

        public virtual DbSet<Case> Case { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Cooler> Cooler { get; set; }
        public virtual DbSet<GPU> GPU { get; set; }
        public virtual DbSet<HDD> HDD { get; set; }
        public virtual DbSet<Motherboard> Motherboard { get; set; }
        public virtual DbSet<Processor> Processor { get; set; }
        public virtual DbSet<PSU> PSU { get; set; }
        public virtual DbSet<RAM> RAM { get; set; }
        public virtual DbSet<SSD> SSD { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.FormFaktor)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Case>()
                .Property(e => e.Price);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Socket)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Power)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<Cooler>()
                .Property(e => e.Price);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.GpuFrequency)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.GpuBoost)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.MemorySize)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.MemoryType)
                .IsUnicode(false);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Price);

            modelBuilder.Entity<GPU>()
                .Property(e => e.Tdp)
                .IsUnicode(false);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HDD>()
                .Property(e => e.Description)
                .IsUnicode(false);
      
            modelBuilder.Entity<PSU>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.PowerSupply)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.FormFactor)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Certificate)
                .IsUnicode(false);

            modelBuilder.Entity<PSU>()
                .Property(e => e.Price);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<SSD>()
                .Property(e => e.Capacity)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<UserRole>()
                .HasMany(e => e.User)
                .WithOptional(e => e.UserRole)
                .HasForeignKey(e => e.Role);
        }
    }
}
