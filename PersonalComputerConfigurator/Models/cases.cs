namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cases
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(50)]
        public string formFaktor { get; set; }

        [StringLength(255)]
        public string size { get; set; }

        [StringLength(50)]
        public string price { get; set; }
    }
}
