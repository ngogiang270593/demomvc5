namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VBPQDocument")]
    public partial class VBPQDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VBPQDocument()
        {
            VBPQChucDanhNguoiKies = new HashSet<VBPQChucDanhNguoiKy>();
            VBPQCoQuanBanHanhDocuments = new HashSet<VBPQCoQuanBanHanhDocument>();
            VBPQLinhVucPhapLuatDocuments = new HashSet<VBPQLinhVucPhapLuatDocument>();
            VBPQPhamViDieuChinhDocuments = new HashSet<VBPQPhamViDieuChinhDocument>();
        }

        public int Id { get; set; }

        [StringLength(1000)]
        public string SoKyHieu { get; set; }

        [StringLength(1000)]
        public string TrichYeu { get; set; }

        public DateTime? NgayBanHanh { get; set; }

        public DateTime? NgayCoHieuLuc { get; set; }

        public DateTime? NgayHetHieuLuc { get; set; }

        public string NoiDung { get; set; }

        public int? LoaiVanBanId { get; set; }

        public int? StatusId { get; set; }

        [StringLength(1000)]
        public string NguonTrich { get; set; }

        [StringLength(1000)]
        public string FileAttach { get; set; }

        public int? SapXep { get; set; }

        public DateTime? NgayDangCongBao { get; set; }

        public int? VanBanCanCuId { get; set; }

        public int? VanBanThayTheId { get; set; }

        public int? VanBanDanChieuId { get; set; }

        public int? VanBanSuaDoiId { get; set; }

        public virtual VBPQCheDinhPhapLuatDocument VBPQCheDinhPhapLuatDocument { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQChucDanhNguoiKy> VBPQChucDanhNguoiKies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQCoQuanBanHanhDocument> VBPQCoQuanBanHanhDocuments { get; set; }

        public virtual VBPQLoaiVanBan VBPQLoaiVanBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQLinhVucPhapLuatDocument> VBPQLinhVucPhapLuatDocuments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VBPQPhamViDieuChinhDocument> VBPQPhamViDieuChinhDocuments { get; set; }
    }
}
