namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseThongBao")]
    public partial class CertifiedHouseThongBao
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string SoThongBao { get; set; }

        public DateTime? NgayThongBao { get; set; }

        [StringLength(200)]
        public string TenCoQuan { get; set; }

        [StringLength(200)]
        public string TenPhongBan { get; set; }

        [StringLength(200)]
        public string DiaChiCoQuan { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [StringLength(50)]
        public string SoBienBan { get; set; }

        [StringLength(200)]
        public string DonViQuanLy { get; set; }

        public DateTime? NgayLapBienBan { get; set; }

        [StringLength(500)]
        public string NoiDungBienBan { get; set; }

        [StringLength(500)]
        public string NoiDungViPham { get; set; }

        [StringLength(50)]
        public string SoGCN { get; set; }

        [StringLength(50)]
        public string CMND { get; set; }

        [StringLength(500)]
        public string KyThay { get; set; }

        [StringLength(500)]
        public string KyThayChucVu { get; set; }

        [StringLength(200)]
        public string ChucVuNguoiKy { get; set; }

        [StringLength(200)]
        public string TenNguoiKy { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiTao { get; set; }

        public DateTime? NgaySua { get; set; }

        [StringLength(50)]
        public string NguoiSua { get; set; }

        public int? HuyenId { get; set; }

        public int? StatusId { get; set; }

        public int? CertifiedID { get; set; }

        [StringLength(500)]
        public string Ref1 { get; set; }

        [StringLength(500)]
        public string Ref2 { get; set; }

        [StringLength(500)]
        public string Ref3 { get; set; }
    }
}
