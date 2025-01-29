namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Processor")]
    public partial class Processor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processor()
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

        [StringLength(50)]
        public string Tdp { get; set; }

        [StringLength(50)]
        public string Frequency { get; set; }

        [StringLength(50)]
        public string Boost { get; set; }

        [StringLength(50)]
        public string Cores { get; set; }

        [StringLength(50)]
        public string Threads { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }
    }
}
