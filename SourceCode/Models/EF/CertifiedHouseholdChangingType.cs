namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdChangingType")]
    public partial class CertifiedHouseholdChangingType
    {
        public int Id { get; set; }

        public int? ChangingTypeiId { get; set; }

        public long? CertifiedID { get; set; }
    }
}
