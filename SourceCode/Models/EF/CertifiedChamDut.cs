namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedChamDut")]
    public partial class CertifiedChamDut
    {
        public int Id { get; set; }

        public long? CertifiedID { get; set; }

        [StringLength(50)]
        public string CertifiedCode { get; set; }

        [StringLength(50)]
        public string Nguoitao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }

        public int? StatusId { get; set; }

        public DateTime? NgayChamDut { get; set; }

        public int? HuyenId { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [StringLength(50)]
        public string Ow_CardID { get; set; }
    }
}
