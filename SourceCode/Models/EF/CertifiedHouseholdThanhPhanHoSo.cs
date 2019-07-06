namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertifiedHouseholdThanhPhanHoSo")]
    public partial class CertifiedHouseholdThanhPhanHoSo
    {
        public int? ThanhPhanHoSoId { get; set; }

        public long? CertifiedID { get; set; }

        public int Id { get; set; }
    }
}
