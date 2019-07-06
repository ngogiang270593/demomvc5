namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHouseQuyetDinh")]
    public partial class HopTacXaHouseQuyetDinh
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string SoQuyetDinh { get; set; }

        public DateTime? NgayQuyetDinh { get; set; }

        [StringLength(200)]
        public string CanCuThongBao { get; set; }

        public DateTime? NgayHieuLuc { get; set; }

        [Column(TypeName = "text")]
        public string CanCu { get; set; }

        [StringLength(200)]
        public string TenCoQuan { get; set; }

        [StringLength(200)]
        public string TenPhongBan { get; set; }

        [StringLength(500)]
        public string KyThay { get; set; }

        [StringLength(500)]
        public string KyThayChucVu { get; set; }

        [StringLength(50)]
        public string ChucVuNguoiKy { get; set; }

        [StringLength(100)]
        public string TenNguoiKy { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(50)]
        public string NguoiSua { get; set; }

        public int? HuyenId { get; set; }

        public int? StatusId { get; set; }

        public int? HopTacXaID { get; set; }

        [StringLength(500)]
        public string Ref1 { get; set; }

        [StringLength(500)]
        public string Ref2 { get; set; }

        [StringLength(500)]
        public string Ref3 { get; set; }
    }
}
