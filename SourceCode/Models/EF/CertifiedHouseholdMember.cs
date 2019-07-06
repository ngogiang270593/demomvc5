namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdMember")]
    public partial class CertifiedHouseholdMember
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string MemberName { get; set; }

        public string MemberAddress { get; set; }

        public string MemberDiaChiHienTai { get; set; }

        [StringLength(20)]
        public string MemberValues { get; set; }

        [StringLength(20)]
        public string MemberRate { get; set; }

        [StringLength(250)]
        public string MemberCard { get; set; }

        [StringLength(250)]
        public string MemberDes { get; set; }

        public int? MemberOrder { get; set; }

        public long? CertifiedID { get; set; }

        [StringLength(50)]
        public string CertifiedCode { get; set; }
    }
}
