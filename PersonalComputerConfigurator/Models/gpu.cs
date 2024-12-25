namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gpu")]
    public partial class gpu
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(50)]
        public string gpuFrequency { get; set; }

        [StringLength(50)]
        public string gpuBoost { get; set; }

        [StringLength(50)]
        public string memorySize { get; set; }

        [StringLength(50)]
        public string memoryType { get; set; }

        [StringLength(50)]
        public string price { get; set; }

        [StringLength(50)]
        public string tdp { get; set; }
    }
}
