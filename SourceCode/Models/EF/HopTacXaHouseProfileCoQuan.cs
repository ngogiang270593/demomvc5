namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseProfileCoQuan")]
    public partial class HopTacXaHouseProfileCoQuan
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string TenCoQuan { get; set; }

        [StringLength(250)]
        public string DiaChiCoQuan { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(50)]
        public string NguoiSua { get; set; }

        public int? HuyenId { get; set; }

        public int? StatusId { get; set; }

        [StringLength(500)]
        public string Ref1 { get; set; }

        [StringLength(500)]
        public string Ref2 { get; set; }

        [StringLength(500)]
        public string Ref3 { get; set; }
    }
}
