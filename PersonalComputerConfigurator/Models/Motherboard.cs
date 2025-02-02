namespace PersonalComputerConfigurator.Models
{
    using PersonalComputerConfigurator.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

    [Table("Motherboard")]
    public partial class Motherboard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Motherboard()
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
        public string RamType { get; set; }

        [StringLength(50)]
        public string Chipset { get; set; }

        [StringLength(255)]
        public string FormFactor { get; set; }

        public int Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }

        public string FullName => $"{Name} | {Socket} | {Chipset} | {FormFactor} | {RamType} | {MoneyService.ToRubles(Price)}₽";

    }
}
