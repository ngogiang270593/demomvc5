namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopTacXaHousehold")]
    public partial class HopTacXaHousehold
    {
        [Key]
        public long HopTacXaID { get; set; }

        [StringLength(50)]
        public string HopTacXaIdOld { get; set; }

        [StringLength(50)]
        public string HopTacXaCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HopTacXaDate { get; set; }

        public int? HopTacXaUp_Time { get; set; }

        public DateTime? HopTacXaUp_Date { get; set; }

        public int? HopTacXaRe_Time { get; set; }

        public DateTime? HopTacXaRe_Date { get; set; }

        [StringLength(250)]
        public string Biz_VietName { get; set; }

        [StringLength(250)]
        public string Biz_ShortName { get; set; }

        [StringLength(2000)]
        public string Biz_HeadOffice { get; set; }

        [StringLength(250)]
        public string Biz_HeadOfficeDes { get; set; }

        [StringLength(50)]
        public string Biz_Tel { get; set; }

        [StringLength(50)]
        public string Biz_Fax { get; set; }

        [StringLength(50)]
        public string Biz_Email { get; set; }

        [StringLength(50)]
        public string Biz_Website { get; set; }

        public double? Biz_InvestCapital { get; set; }

        [StringLength(250)]
        public string Biz_WordsMoney { get; set; }

        [StringLength(50)]
        public string Ow_Name { get; set; }

        public int? Ow_Sex { get; set; }

        [StringLength(50)]
        public string Ow_BirthDate { get; set; }

        [StringLength(50)]
        public string Ow_National_ID { get; set; }

        [StringLength(50)]
        public string Ow_Nationality_ID { get; set; }

        [StringLength(50)]
        public string Ow_CardID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ow_CardDate { get; set; }

        [StringLength(250)]
        public string Ow_Provider_ID { get; set; }

        [StringLength(250)]
        public string Ow_Doc_ID { get; set; }

        [StringLength(50)]
        public string Ow_DocCode { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Ow_DocDate { get; set; }

        [StringLength(250)]
        public string Ow_DocOffiHopTacXaID { get; set; }

        [StringLength(50)]
        public string Ow_Tel { get; set; }

        [StringLength(50)]
        public string Ow_Fax { get; set; }

        [StringLength(50)]
        public string Ow_Email { get; set; }

        [StringLength(50)]
        public string Ow_WebSite { get; set; }

        [StringLength(250)]
        public string Ow_Resident { get; set; }

        [StringLength(250)]
        public string Ow_Present { get; set; }

        [StringLength(250)]
        public string HopTacXaDes { get; set; }

        [StringLength(250)]
        public string HopTacXaProviderOrg { get; set; }

        [StringLength(250)]
        public string HopTacXaDeptName { get; set; }

        [StringLength(150)]
        public string HopTacXaBeHaft { get; set; }

        [StringLength(150)]
        public string HopTacXaSignFor { get; set; }

        [StringLength(50)]
        public string HopTacXaSignerName { get; set; }

        [StringLength(100)]
        public string HopTacXaSignerPosition { get; set; }

        [StringLength(1)]
        public string HopTacXaStatus { get; set; }

        public int? HopTacXaIndex { get; set; }

        [StringLength(50)]
        public string Properties_ID { get; set; }

        [StringLength(50)]
        public string Files_ID { get; set; }

        [StringLength(50)]
        public string Ow_TaxCode { get; set; }

        public int? Orders { get; set; }

        public int? ProvinceId { get; set; }

        public int? XaPhuongId { get; set; }

        public DateTime? Created { get; set; }

        [StringLength(50)]
        public string Creator { get; set; }

        public DateTime? Modified { get; set; }

        [StringLength(50)]
        public string Modifier { get; set; }

        public int? StatusId { get; set; }

        [StringLength(50)]
        public string ThayMat { get; set; }

        public string NganhNgheKinhDoanh { get; set; }

        [StringLength(200)]
        public string LinhVucKinhDoanh { get; set; }

        [StringLength(50)]
        public string MaBienNhan { get; set; }

        [StringLength(200)]
        public string TenLinhVuc { get; set; }

        public int? NguonTao { get; set; }

        public int? FlagUpdate { get; set; }

        public DateTime? NgayCapNhatMST { get; set; }

        public DateTime? NgayNgungGCN { get; set; }

        public DateTime? NgayNgungMST { get; set; }

        public long? ParentId { get; set; }

        [StringLength(500)]
        public string Ref1 { get; set; }

        [StringLength(100)]
        public string Ref2 { get; set; }

        [StringLength(100)]
        public string Ref3 { get; set; }

        [StringLength(50)]
        public string VonTienMat { get; set; }

        [StringLength(50)]
        public string VonTaiSan { get; set; }

        public DateTime? NgayTraHoSo { get; set; }

        [StringLength(50)]
        public string SoBienNhan { get; set; }

        public bool? IsMaSoThue { get; set; }

        public int IsGhiChu { get; set; }

        public int ISO { get; set; }

        public int SoLaoDong { get; set; }

        public int? QuyetDinhChamDut { get; set; }

        [StringLength(250)]
        public string Biz_EngName { get; set; }

        [StringLength(250)]
        public string Ow_Name_Bra { get; set; }

        [StringLength(250)]
        public string Ow_Address_Bra { get; set; }

        [StringLength(250)]
        public string Ow_Name_ReOf { get; set; }

        [StringLength(250)]
        public string Ow_Address_ReOf { get; set; }

        [StringLength(250)]
        public string Ow_Name_BuLo { get; set; }

        [StringLength(250)]
        public string Ow_Address_BuLo { get; set; }
    }
}
