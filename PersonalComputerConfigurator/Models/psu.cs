namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PSU")]
    public partial class PSU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PSU()
        {
            Configuration = new HashSet<Configuration>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string PowerSupply { get; set; }

        [StringLength(50)]
        public string FormFactor { get; set; }

        [StringLength(50)]
        public string Certificate { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }
    }
}
