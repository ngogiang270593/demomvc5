namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaTamNgung")]
    public partial class HopTacXaTamNgung
    {
        public int Id { get; set; }

        public long? HopTacXaID { get; set; }

        [StringLength(50)]
        public string HopTacXaCode { get; set; }

        [StringLength(500)]
        public string ThoiGianTamNgung { get; set; }

        public DateTime? BatDate { get; set; }

        public DateTime? KetThuc { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiSua { get; set; }

        [StringLength(50)]
        public string NgaySua { get; set; }

        public int? HuyenId { get; set; }
    }
}
