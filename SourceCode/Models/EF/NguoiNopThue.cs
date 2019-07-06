namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiNopThue")]
    public partial class NguoiNopThue
    {
        public long Id { get; set; }

        public string CoQuanThue { get; set; }

        public string TenCoQuanThue { get; set; }

        public string NguoiNopThue1 { get; set; }

        public string MaSoThue { get; set; }

        public string TenNguoiNopThue { get; set; }

        public string MaNganhNgheKDChinh { get; set; }

        public string TenNganhNgheKDChinh { get; set; }

        public string SoNhaDuongPho { get; set; }

        public string MaPhuongXa { get; set; }

        public string TenPhuongXa { get; set; }

        public string MaQuanHuyen { get; set; }

        public string TenQuanHuyen { get; set; }

        public string MaTinhThanhPho { get; set; }

        public string TenTinhThanhPho { get; set; }

        public string MaQuocGia { get; set; }

        public string TenQuocGia { get; set; }

        public string TongSoLaoDong { get; set; }

        public string NganhNgheKinhDoanh { get; set; }

        public string TenGiamDoc { get; set; }

        public string DienThoaiGiamDoc { get; set; }

        public string TenKeToanTruong { get; set; }

        public string DienThoaiKeToanTruong { get; set; }

        public string SoGiayTo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        public string LoaiGiayTo { get; set; }

        public string SoGiayThongHanh { get; set; }

        public string SoTheQuanNhan { get; set; }

        public string SoCMNDCuaNguoiDaiDien { get; set; }

        public string SoGiayToKhac { get; set; }

        public string PhuongPhapTinhThue { get; set; }

        public string SoCMNDCuaChuDoanhNghiep { get; set; }

        public string SoGiayChungNhanDangKyKinhDoanh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapGiayChungNhanDKKD { get; set; }

        public string SoQuyetDinhThanhLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayQuyetDinhThanhLap { get; set; }

        public string SoHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapHopDong { get; set; }

        public string CoChiNhanh { get; set; }

        public string SoCMND { get; set; }

        public string SoHoChieu { get; set; }

        public string Chuong { get; set; }

        public string Khoan { get; set; }

        public string LoaiNguoiNopThue { get; set; }

        public string TrangThaiDKTCaNhan { get; set; }

        public string TrangThaiDKTToChuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhanToKhai { get; set; }

        public string LoaiHinhKinhTe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TamNghiTuNgay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TamNghiDenNgay { get; set; }

        public string LyDoTamNghi { get; set; }

        public string LyDoDongMSTCaNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDongTrangThaiCaNhan { get; set; }

        public string LyDoDongMSTToChuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDongTrangThaiToChuc { get; set; }

        public string NoiSinh { get; set; }

        public string QuocTich { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public string SoHoChieuCuaChuDoanhNghiep { get; set; }

        public string SoTheQuanNhanCuaChuDoanhNghiep { get; set; }

        public string SoGiayThongHanhCuaChuDoanhNghiep { get; set; }

        public string VonKinhDoanh { get; set; }

        public string NguonVonNSNN { get; set; }

        public string NguonVonNuocNgoai { get; set; }

        public string NguonVonKhac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDauKinhDoanh { get; set; }

        public string DienThoaiBan { get; set; }

        public string SoMayLe { get; set; }

        public string DienThoaiDiDong { get; set; }

        public string DiaChiEmail { get; set; }

        public string SoTaiKhoan { get; set; }

        public string TenNganHang1 { get; set; }

        public string TenNganHang2 { get; set; }

        public string HThucHToan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamTaiChinhTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamTaiChinhDen { get; set; }

        public string EmailTBThue { get; set; }

        public bool? IsCMND { get; set; }

        public bool? IsGCN { get; set; }
    }
}
