namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("psu")]
    public partial class psu
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string powerSupply { get; set; }

        [StringLength(50)]
        public string formFactor { get; set; }

        [StringLength(50)]
        public string certificate { get; set; }

        [StringLength(50)]
        public string price { get; set; }
    }
}
