namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdDonViLienHe")]
    public partial class CertifiedHouseholdDonViLienHe
    {
        public int Id { get; set; }

        public long? CertifiedID { get; set; }

        public int? DonViLienHeId { get; set; }
    }
}
