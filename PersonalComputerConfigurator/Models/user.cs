namespace PersonalComputerConfigurator.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string middleName { get; set; }

        [StringLength(50)]
        public string lastName { get; set; }

        public string password { get; set; }

        public int? role { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        public virtual userRole userRole { get; set; }
    }
}
