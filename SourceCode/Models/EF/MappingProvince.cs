namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MappingProvince")]
    public partial class MappingProvince
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string ProvinceIdMC { get; set; }

        [StringLength(10)]
        public string ProvinceIdDKHKD { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }
    }
}
