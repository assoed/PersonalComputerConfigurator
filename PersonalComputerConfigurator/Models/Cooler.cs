namespace PersonalComputerConfigurator.Models
{
    using PersonalComputerConfigurator.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.InteropServices;

    [Table("Cooler")]
    public partial class Cooler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cooler()
        {
            Configuration = new HashSet<Configuration>();
        }

        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Socket { get; set; }

        [StringLength(255)]
        public string Power { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Material { get; set; }

        public int Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }

        public string FullName => $"{Name} | {Socket} | {Type} | {Material} | {MoneyService.ToRubles(Price)}₽";
    }
}
