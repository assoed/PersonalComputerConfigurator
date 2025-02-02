namespace PersonalComputerConfigurator.Models
{
    using PersonalComputerConfigurator.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;

    [Table("RAM")]
    public partial class RAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAM()
        {
            Configuration = new HashSet<Configuration>();
        }

        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [StringLength(255)]
        public string FormFactor { get; set; }

        [StringLength(255)]
        public string Capacity { get; set; }

        [StringLength(255)]
        public string Frequency { get; set; }

        public int Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }

        public string FullName => $"{Name} | {Type} | {FormFactor} | {Frequency} | {Capacity} | {MoneyService.ToRubles(Price)}₽";

    }
}
