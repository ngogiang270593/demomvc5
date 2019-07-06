namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NopThue")]
    public partial class NopThue
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string MST { get; set; }

        [StringLength(300)]
        public string HoTen { get; set; }

        [StringLength(1000)]
        public string DiaChi { get; set; }

        [StringLength(1000)]
        public string NganhNghe { get; set; }

        [StringLength(50)]
        public string SoGCN { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public DateTime? NgayCap { get; set; }

        [StringLength(50)]
        public string SoGCNHo { get; set; }

        [StringLength(50)]
        public string CMNDHo { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        [StringLength(100)]
        public string Ref1 { get; set; }

        [StringLength(100)]
        public string Ref2 { get; set; }

        public int? HuyenId { get; set; }
    }
}
