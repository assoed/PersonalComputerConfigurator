namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class motherboards
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string socket { get; set; }

        [StringLength(255)]
        public string ramType { get; set; }

        [StringLength(50)]
        public string chipset { get; set; }

        [StringLength(255)]
        public string formFactor { get; set; }

        [StringLength(255)]
        public string price { get; set; }
    }
}
