namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_PARAMETERS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Val { get; set; }

        public string Val2 { get; set; }

        public int? Type { get; set; }

        public string Description { get; set; }

        public bool? IsSystem { get; set; }

        public bool Activated { get; set; }
    }
}
