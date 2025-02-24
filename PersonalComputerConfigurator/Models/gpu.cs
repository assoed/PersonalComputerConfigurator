namespace PersonalComputerConfigurator.Models
{
    using PersonalComputerConfigurator.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GPU")]
    public partial class GPU : IComponentWithPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GPU()
        {
            Configuration = new HashSet<Configuration>();
        }

        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(50)]
        public string GpuFrequency { get; set; }

        [StringLength(50)]
        public string GpuBoost { get; set; }

        [StringLength(50)]
        public string MemorySize { get; set; }

        [StringLength(50)]
        public string MemoryType { get; set; }

        public int Price { get; set; }

        [StringLength(50)]
        public string Tdp { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }
    }
}
