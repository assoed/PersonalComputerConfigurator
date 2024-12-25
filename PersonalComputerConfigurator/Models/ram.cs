namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ram")]
    public partial class ram
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string formFactor { get; set; }

        [StringLength(255)]
        public string capacity { get; set; }

        [StringLength(255)]
        public string frequency { get; set; }

        [MaxLength(50)]
        public string price { get; set; }
    }
}
