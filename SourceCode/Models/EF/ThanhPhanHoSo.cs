namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhPhanHoSo")]
    public partial class ThanhPhanHoSo
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string MaHoSo { get; set; }

        [StringLength(500)]
        public string TenHoSo { get; set; }

        [StringLength(500)]
        public string LoaiCap { get; set; }

        public int? Sort { get; set; }

        public bool? IsDefault { get; set; }
    }
}
