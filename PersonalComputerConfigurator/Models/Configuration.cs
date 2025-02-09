namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Configuration")]
    public partial class Configuration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Configuration()
        {
            ConfigurationWarning = new HashSet<ConfigurationWarning>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? CaseID { get; set; }

        public int? CoolerID { get; set; }

        public int? GpuID { get; set; }

        public int? HddID { get; set; }

        public int? MotherboardID { get; set; }

        public int? ProcessorID { get; set; }

        public int? PsuID { get; set; }

        public int? SsdID { get; set; }

        public int? RamID { get; set; }

        public int? UserID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public int? ConfigPrice { get; set; }

        public virtual Case Case { get; set; }

        public virtual SSD SSD { get; set; }

        public virtual Cooler Cooler { get; set; }

        public virtual GPU GPU { get; set; }

        public virtual HDD HDD { get; set; }

        public virtual Motherboard Motherboard { get; set; }

        public virtual Processor Processor { get; set; }

        public virtual PSU PSU { get; set; }

        public virtual RAM RAM { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigurationWarning> ConfigurationWarning { get; set; }
    }
}
