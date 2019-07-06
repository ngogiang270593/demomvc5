namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhBaTCKHHuyen")]
    public partial class DanhBaTCKHHuyen
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(500)]
        public string ChucVu { get; set; }

        [StringLength(50)]
        public string DienThoaiBan { get; set; }

        [StringLength(50)]
        public string DienThoaiDiDong { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public int? HuyenId { get; set; }

        public int? Sort { get; set; }
    }
}
