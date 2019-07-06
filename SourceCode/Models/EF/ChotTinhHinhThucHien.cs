namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChotTinhHinhThucHien")]
    public partial class ChotTinhHinhThucHien
    {
        public int Id { get; set; }

        public int? HuyenId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayChot { get; set; }

        public int? LinhVucId { get; set; }

        public int? LuyKe { get; set; }

        [StringLength(2000)]
        public string CoSo { get; set; }

        [StringLength(2000)]
        public string Von { get; set; }

        [StringLength(2000)]
        public string LaoDong { get; set; }

        [StringLength(1)]
        public string LoaiCap { get; set; }
    }
}
