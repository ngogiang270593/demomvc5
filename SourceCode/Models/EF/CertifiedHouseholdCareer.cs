namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdCareer")]
    public partial class CertifiedHouseholdCareer
    {
        public int Id { get; set; }

        public long? CertifiedID { get; set; }

        [StringLength(50)]
        public string CertifiedCode { get; set; }

        [StringLength(50)]
        public string CareerCode { get; set; }

        [StringLength(400)]
        public string CareerName { get; set; }
    }
}
