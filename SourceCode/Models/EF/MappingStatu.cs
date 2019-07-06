namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MappingStatu
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string StatusIdMC { get; set; }

        [StringLength(10)]
        public string StatusIdDKHKD { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
