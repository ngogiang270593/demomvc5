namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdNganhNghe")]
    public partial class CertifiedHouseholdNganhNghe
    {
        public int Id { get; set; }

        public long? CertifiedID { get; set; }

        public int? DanhMucNganhNgheID { get; set; }

        public string Description { get; set; }
    }
}
