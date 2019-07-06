namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoSoMoiAGESB")]
    public partial class HoSoMoiAGESB
    {
        public int Id { get; set; }

        public string MaBNHS { get; set; }

        public string TenToChuc { get; set; }

        public string tenBangHieu { get; set; }

        public string diaChiKinhDoanh { get; set; }

        public string TenNguoiNop { get; set; }

        public string DiaChiNguoiNop { get; set; }

        public string SoCMND { get; set; }

        public string DienThoai { get; set; }

        public string TenDVCong { get; set; }

        public string NgayNhanHS { get; set; }

        public string NgayHenTraHS { get; set; }

        public string TinhTrangHS { get; set; }

        public string TrangThaiXuLy { get; set; }

        public string PhongBanXuLy { get; set; }

        public string CVXuLy { get; set; }

        public string DinhKem { get; set; }

        public string DuLieuChuyenNganh { get; set; }

        public string MaThongDiep { get; set; }

        public string NgayNhanThongDiep { get; set; }

        public string MaDonViGoi { get; set; }

        public string MaLinhVuc { get; set; }

        public string MaDichVu { get; set; }

        public string MaLoaiThongDiep { get; set; }

        public string MaDonViNhan { get; set; }

        public string Kq { get; set; }

        public int? StatusId { get; set; }
    }
}
