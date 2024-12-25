namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class processors
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string socket { get; set; }

        [StringLength(50)]
        public string tdp { get; set; }

        [StringLength(50)]
        public string frequency { get; set; }

        [StringLength(50)]
        public string boost { get; set; }

        [StringLength(50)]
        public string cores { get; set; }

        [StringLength(50)]
        public string threads { get; set; }

        [StringLength(50)]
        public string price { get; set; }
    }
}
