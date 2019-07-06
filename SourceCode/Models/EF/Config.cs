namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config")]
    public partial class Config
    {
        public int Id { get; set; }

        public int? ProvinceId { get; set; }

        public int? IsMotCuaNhapNghanhNghe { get; set; }

        [StringLength(50)]
        public string BuoiTraHoSo { get; set; }

        [StringLength(300)]
        public string Ref1 { get; set; }

        [StringLength(300)]
        public string Ref2 { get; set; }

        [StringLength(300)]
        public string Ref3 { get; set; }

        public int? Ref4 { get; set; }

        public string MauBienNhan { get; set; }

        public string MauGiayChungNhan { get; set; }

        public int? IsLanCap { get; set; }

        public int? IsDongNgoacLanCap { get; set; }

        public int? IsChiTietNganhNgheDangBang { get; set; }

        public int? IsChiTietMaNganhNghe { get; set; }

        public int? IsLoaiGiayChungThuc { get; set; }

        public string MauThongBao { get; set; }

        public string MauQuyetDinh { get; set; }

        public string MauHuongDan { get; set; }

        public string DonViCap { get; set; }

        public string PhongBanCap { get; set; }

        public string KyThay { get; set; }

        public string KyThayChucVu { get; set; }

        public string NguoiKy { get; set; }

        public string NguoiKyChucVu { get; set; }

        public int? TichHopTruc { get; set; }

        public int? TichHopMcc { get; set; }

        public string MaDonViGui { get; set; }

        public string MauGiayChungNhanHTX { get; set; }

        public string MauBienNhanHTX { get; set; }

        public string MauThongBaoHTX { get; set; }

        public string MauQuyetDinhHTX { get; set; }

        public string MauHuongDanHTX { get; set; }
    }
}
