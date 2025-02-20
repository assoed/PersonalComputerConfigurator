namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfigurationWarning")]
    public partial class ConfigurationWarning
    {
        [Key]
        public int WarningID { get; set; }

        public int ConfigID { get; set; }

        [StringLength(255)]
        public string WarningText { get; set; }

        public virtual Configuration Configuration { get; set; }
    }
}
